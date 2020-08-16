using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria
{
    public partial class Principal : Form
    {
        frmAlunos alun = new frmAlunos();
        Base_frm boletim = new Base_frm();
        public Principal()
        {
            InitializeComponent();
            
            //alun.WindowState = FormWindowState.Maximized;
            
            //alun.MdiParent = this;
            //alun.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void exibiJanela(Form alun)
        {
            
            if (alun.IsMdiChild == true)
            {
                if (alun.WindowState == FormWindowState.Minimized)
                {
                    alun.WindowState = FormWindowState.Maximized;
                }
                
                
            }
            else
            {
                


                alun.MdiParent = this;
                alun.Show();
            }
        }
        private void exibirJanelaNoPainel(Form janela)
        {
            if (this.painel.Controls.Count > 0)
                this.painel.Controls.RemoveAt(0);
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;
            this.painel.Controls.Add(janela);
            this.painel.Tag = janela;
            janela.Show();
        }
        private void carambaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            exibirJanelaNoPainel(alun);
        }

        private void merdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibirJanelaNoPainel(boletim);
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void telaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
