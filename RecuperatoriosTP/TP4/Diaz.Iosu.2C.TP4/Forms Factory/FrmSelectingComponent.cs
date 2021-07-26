using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Factory
{
    public partial class FrmSelectingComponent<T> : Form where T: Entities.Components.Component, new()
    {
        public T Return
        {
            get;

            set;
            
        }


        public FrmSelectingComponent(List<T> components)
        {
            InitializeComponent();
            this.dgvComponentes.DataSource = components;
            this.lblComponentName.Text = typeof(T).Name;
        }

        private void FrmSelectingComponent_Load(object sender, EventArgs e)
        {

        }

        private void dgvComponentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            T var = Assembler.Assemble<T>();
            this.dgvComponentes.CurrentRow.Selected = true;
            var.Brand = this.dgvComponentes.Rows[e.RowIndex].Cells["brandDataGridViewTextBoxColumn"].Value.ToString();
            var.Model = this.dgvComponentes.Rows[e.RowIndex].Cells["modelDataGridViewTextBoxColumn"].Value.ToString();

            this.Return = var;
            this.Close();
        }

        private void btnCancelSelection_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
