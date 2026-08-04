using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace TesteSimulador
{
    public class GeradorPDF
    {
        public string Gerar(Proposta proposta, ResultadoCalculo resultado)
        {
            string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Propostas");
            Directory.CreateDirectory(pasta);

            string arquivo = Path.Combine(pasta, $"Proposta_{proposta.NomeCliente}.pdf");

            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(arquivo, FileMode.Create));
            writer.PageEvent = new MarcaDagua();

            doc.Open();

            string logo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png");

            if (File.Exists(logo))
            {
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(logo);
                img.ScaleToFit(120, 80);
                img.Alignment = Element.ALIGN_CENTER;
                doc.Add(img);
            }

            Paragraph titulo = new Paragraph( "PROPOSTA DE CONSÓRCIO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));

            Titulo(doc, "DADOS DO CLIENTE");
            Linha(doc, "Cliente", proposta.NomeCliente);
            Titulo(doc, "DADOS DO CONSÓRCIO");
            Linha(doc, "Administradora", proposta.Administradora);
            Linha(doc, "Valor da Carta", proposta.ValorBem.ToString("C2"));
            Linha(doc, "Prazo", proposta.Prazo + " meses");
            Titulo(doc, "COMPOSIÇÃO DA PARCELA");
            Linha(doc, "Fundo Comum", resultado.FundoComum.ToString("C2"));
            Linha(doc, "Taxa Administrativa", resultado.ValorTaxaAdmin.ToString("C2"));
            Linha(doc, "Fundo Reserva", resultado.ValorFundoReserva.ToString("C2"));
            Linha(doc, "Parcela Normal", resultado.ParcelaAntesContemplacao.ToString("C2"));
            Titulo(doc, "PLANO DE ADESÃO");
            Linha(doc, "Adesão Total", resultado.ValorTotalAdesao.ToString("C2"));
            Linha(doc, "Parcelamento", proposta.QuantidadeParcelasAdesao + "x");
            Linha(doc, "Valor Parcela Adesão", resultado.ValorParcelaAdesao.ToString("C2"));
            Linha(doc, "Primeiras Parcelas", (resultado.ParcelaAntesContemplacao + resultado.ValorParcelaAdesao).ToString("C2"));
            Titulo(doc, "LANCE DE CONTEMPLAÇÃO");
            Linha(doc, "Tipo Lance", proposta.TipoLance == 1 ? "Lance Livre" : "Lance Embutido");
            Linha(doc, "Percentual",                resultado.PercentualLance.ToString("0.##") + "%");
            Linha(doc,               "Valor Lance",                resultado.ValorLance.ToString("C2"));
            if (proposta.TipoLance == 1 && resultado.ParcelasReduzidasLance > 0)
            {
                Linha(doc, "Redução", resultado.ParcelasReduzidasLance + " parcelas");
                Linha(doc, "Novo Prazo", resultado.PrazoFinal + " meses");
            }
            
            Titulo(doc, "RESUMO FINAL");
            Linha(doc, "Parcela Pós Contemplação", resultado.ParcelaPosContemplacao.ToString("C2"));
            Linha(doc, "Valor Total Operação", resultado.ValorTotalOperacao.ToString("C2"));

            doc.Add(new Paragraph(" "));

            Paragraph rodape = new Paragraph( "CONSULTORIA BENVENUTO\nProposta gerada automaticamente", FontFactory.GetFont(FontFactory.HELVETICA, 9));

            rodape.Alignment = Element.ALIGN_CENTER;
            doc.Add(rodape);

            doc.Close();

            return arquivo;
        }


        private void Titulo(Document doc, string texto)
        {
            PdfPTable tabela = new PdfPTable(1);
            tabela.WidthPercentage = 100;

            PdfPCell celula = new PdfPCell(new Phrase(texto,FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE)));

            celula.BackgroundColor = new BaseColor(25, 80, 150);
            celula.Padding = 5;

            tabela.AddCell(celula);
            doc.Add(tabela);
        }


        private void Linha(Document doc, string campo, string valor)
        {
            PdfPTable tabela = new PdfPTable(2);
            tabela.WidthPercentage = 100;

            tabela.SetWidths(new float[] { 40, 60 });

            PdfPCell c1 = new PdfPCell(new Phrase(campo));
            PdfPCell c2 = new PdfPCell(new Phrase(valor));

            c1.Padding = 5;
            c2.Padding = 5;

            tabela.AddCell(c1);
            tabela.AddCell(c2);

            doc.Add(tabela);
        }
    }


    public class MarcaDagua : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            string logo = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "logo.png");

            if (File.Exists(logo))
            {
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(logo);

                img.ScaleToFit(250, 250);
                img.SetAbsolutePosition(170, 300);

                PdfGState estado = new PdfGState();
                estado.FillOpacity = 0.06f;

                writer.DirectContentUnder.SaveState();
                writer.DirectContentUnder.SetGState(estado);
                writer.DirectContentUnder.AddImage(img);
                writer.DirectContentUnder.RestoreState();
            }
        }
    }
}
