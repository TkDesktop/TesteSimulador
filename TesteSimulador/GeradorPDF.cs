using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace TesteSimulador
{
    public class GeradorPDF
    {
        public string Gerar(Proposta proposta, ResultadoSimulacao resultado)
        {
            // Salva na pasta 'Propostas' na Área de Trabalho
            string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Propostas");
            Directory.CreateDirectory(pasta);

            string arquivo = Path.Combine(pasta, $"Proposta_{proposta.NomeCliente}.pdf");

            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(arquivo, FileMode.Create));

            // Evento para renderizar a marca d'água no fundo da página
            writer.PageEvent = new MarcaDagua();

            doc.Open();

            // Adiciona logotipo no topo (se existir na pasta da aplicação)
            string caminhoLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png");

            if (File.Exists(caminhoLogo))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoLogo);
                logo.ScaleToFit(120, 80);
                logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);
            }

            // Título
            Paragraph titulo = new Paragraph("PROPOSTA DE CONSÓRCIO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" ")); // Espaçamento

            // Bloco 1: Cliente
            AdicionarTituloSecao(doc, "DADOS DO CLIENTE");
            AdicionarLinhaGrid(doc, "Cliente", proposta.NomeCliente);

            // Bloco 2: Consórcio
            AdicionarTituloSecao(doc, "DADOS DO CONSÓRCIO");
            AdicionarLinhaGrid(doc, "Administradora", proposta.Administradora);
            AdicionarLinhaGrid(doc, "Valor da Carta", proposta.ValorBem.ToString("C2"));
            AdicionarLinhaGrid(doc, "Prazo", proposta.Prazo + " meses");

            // Bloco 3: Composição Parcela
            AdicionarTituloSecao(doc, "COMPOSIÇÃO DA PARCELA");
            AdicionarLinhaGrid(doc, "Fundo Comum", resultado.FundoComumMensal.ToString("C2"));
            AdicionarLinhaGrid(doc, "Taxa Administrativa", resultado.TaxaAdministracaoMensal.ToString("C2"));
            AdicionarLinhaGrid(doc, "Fundo Reserva", resultado.FundoReservaMensal.ToString("C2"));
            AdicionarLinhaGrid(doc, "Parcela Normal", resultado.ParcelaMensal.ToString("C2"));

            // Bloco 4: Adesão
            AdicionarTituloSecao(doc, "PLANO DE ADESÃO");
            AdicionarLinhaGrid(doc, "Adesão Mensal", resultado.AdesaoMensal.ToString("C2"));
            AdicionarLinhaGrid(doc, "Parcelamento", proposta.QuantidadeParcelasAdesao + "x");

            // Bloco 5: Lance
            AdicionarTituloSecao(doc, "LANCE DE CONTEMPLAÇÃO");
            AdicionarLinhaGrid(doc, "Tipo Lance", proposta.TipoLance == 1 ? "Lance Livre" : "Lance Embutido");
            AdicionarLinhaGrid(doc, "Percentual", resultado.PercentualLance.ToString("0.##") + "%");
            AdicionarLinhaGrid(doc, "Valor do Lance", resultado.ValorLance.ToString("C2"));

            if (resultado.NovoPrazoComReducaoDePrazo.HasValue && resultado.NovoPrazoComReducaoDePrazo > 0)
            {
                AdicionarLinhaGrid(doc, "Novo Prazo Pós-Lance", resultado.NovoPrazoComReducaoDePrazo.Value + " meses");
            }

            // Bloco 6: Resumo
            AdicionarTituloSecao(doc, "RESUMO FINAL");
            decimal posContemplacao = resultado.NovaParcelaComReducaoDeParcela ?? resultado.ParcelaMensal;
            AdicionarLinhaGrid(doc, "Parcela Pós Contemplação", posContemplacao.ToString("C2"));
            AdicionarLinhaGrid(doc, "Valor Total Operação", resultado.TotalPlano.ToString("C2"));

            doc.Add(new Paragraph(" "));

            // Rodapé
            Paragraph rodape = new Paragraph("CONSULTORIA BENVENUTO\nProposta gerada automaticamente pelo Simulador", FontFactory.GetFont(FontFactory.HELVETICA, 9));
            rodape.Alignment = Element.ALIGN_CENTER;
            doc.Add(rodape);

            doc.Close();

            return arquivo;
        }

        private void AdicionarTituloSecao(Document doc, string texto)
        {
            PdfPTable tabela = new PdfPTable(1) { WidthPercentage = 100 };
            PdfPCell celula = new PdfPCell(new Phrase(texto, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE)))
            {
                BackgroundColor = new BaseColor(25, 80, 150),
                Padding = 5
            };

            tabela.AddCell(celula);
            doc.Add(tabela);
        }

        private void AdicionarLinhaGrid(Document doc, string campo, string valor)
        {
            PdfPTable tabela = new PdfPTable(2) { WidthPercentage = 100 };
            tabela.SetWidths(new float[] { 40, 60 });

            PdfPCell c1 = new PdfPCell(new Phrase(campo, FontFactory.GetFont(FontFactory.HELVETICA, 10))) { Padding = 4 };
            PdfPCell c2 = new PdfPCell(new Phrase(valor, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { Padding = 4 };

            tabela.AddCell(c1);
            tabela.AddCell(c2);

            doc.Add(tabela);
        }
    }

    public class MarcaDagua : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            string caminhoLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png");

            if (File.Exists(caminhoLogo))
            {
                iTextSharp.text.Image marca = iTextSharp.text.Image.GetInstance(caminhoLogo);
                marca.ScaleToFit(250, 250);
                marca.SetAbsolutePosition(170, 300);

                PdfGState estado = new PdfGState { FillOpacity = 0.06f };

                writer.DirectContentUnder.SaveState();
                writer.DirectContentUnder.SetGState(estado);
                writer.DirectContentUnder.AddImage(marca);
                writer.DirectContentUnder.RestoreState();
            }
        }
    }
}
