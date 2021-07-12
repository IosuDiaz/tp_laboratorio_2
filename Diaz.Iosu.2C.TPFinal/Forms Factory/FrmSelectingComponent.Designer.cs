
namespace Forms_Factory
{
    partial class FrmSelectingComponent<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblComponentName = new System.Windows.Forms.Label();
            this.lblManualDeUso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AllowUserToDeleteRows = false;
            this.dgvComponentes.AutoGenerateColumns = false;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.dgvComponentes.DataSource = this.componentBindingSource;
            this.dgvComponentes.Location = new System.Drawing.Point(12, 87);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.Size = new System.Drawing.Size(776, 351);
            this.dgvComponentes.TabIndex = 0;
            this.dgvComponentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComponentes_CellDoubleClick);
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataSource = typeof(Entities.Components.Component);
            // 
            // lblComponentName
            // 
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Location = new System.Drawing.Point(12, 71);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(35, 13);
            this.lblComponentName.TabIndex = 1;
            this.lblComponentName.Text = "label1";
            // 
            // lblManualDeUso
            // 
            this.lblManualDeUso.AutoSize = true;
            this.lblManualDeUso.Location = new System.Drawing.Point(574, 71);
            this.lblManualDeUso.Name = "lblManualDeUso";
            this.lblManualDeUso.Size = new System.Drawing.Size(214, 13);
            this.lblManualDeUso.TabIndex = 2;
            this.lblManualDeUso.Text = "Doble click para seleccionar el componente";
            // 
            // FrmSelectingComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblManualDeUso);
            this.Controls.Add(this.lblComponentName);
            this.Controls.Add(this.dgvComponentes);
            this.Name = "FrmSelectingComponent";
            this.Text = "FrmSelectingComponent";
            this.Load += new System.EventHandler(this.FrmSelectingComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.Label lblManualDeUso;
    }
}