using Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmPrincipal : Form
    {
        Livro novoLivro;
        int id = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            novoLivro = new Livro();

            try
            {   
                novoLivro.Titulo = Auxilio.validarCampoTexto(tbTitulo.Text) ? tbTitulo.Text.Trim() : throw new Exception("Campo 'Título' inválido");
                novoLivro.Isbn = Auxilio.validarCampoTexto(tbIsbn.Text) ? tbIsbn.Text.Trim() : throw new Exception("Campo 'ISBN' inválido");
                novoLivro.Autor = Auxilio.validarCampoTexto(tbAutor.Text) ? tbAutor.Text.Trim() : throw new Exception("Campo 'Autor' inválido");
                novoLivro.Editora = Auxilio.validarCampoTexto(tbEditora.Text) ? tbEditora.Text.Trim() : throw new Exception("Campo 'Editora' inválida");
                novoLivro.AnoPub = Auxilio.validarAno(mskAnoPub.Text.Trim()) ? Convert.ToInt32(mskAnoPub.Text.Trim()) : throw new Exception("Campo 'Ano de publicação' inválido");
                novoLivro.Edicao = Auxilio.validarCampoNumero(mskEdicao.Text.Trim()) ? Convert.ToInt32(mskEdicao.Text.Trim()) : throw new Exception("Campo 'Edição' inválido");
                novoLivro.Paginas = Auxilio.validarCampoNumero(mskPaginas.Text.Trim()) ? Convert.ToInt32(mskEdicao.Text.Trim()) : throw new Exception("Campo 'Número de páginas' inválido");
                adicionarNovoLivro(novoLivro);                                
                limparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }
        private void adicionarNovoLivro(Livro livro)
        {
            gvListaLivro.Rows.Add(new object[]
            {
                livro.Titulo,
                livro.Isbn,
                livro.Autor,
                livro.Editora,
                livro.AnoPub,
                livro.Edicao,
                livro.Paginas
            });
        }
        private void limparFormulario()
        {
            foreach (Control child in gbCadLivro.Controls)
            {
                if (child is TextBox || child is MaskedTextBox)
                {
                    child.ResetText();
                }
            }
        }
    }
}
