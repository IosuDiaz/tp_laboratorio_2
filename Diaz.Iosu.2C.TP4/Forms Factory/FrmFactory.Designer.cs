
namespace Forms_Factory
{
    partial class FrmFactory
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
            this.rtbListaProductos = new System.Windows.Forms.RichTextBox();
            this.btnAssemblePC = new System.Windows.Forms.Button();
            this.btnAssembleMotherboard = new System.Windows.Forms.Button();
            this.lblSelectComponents = new System.Windows.Forms.Label();
            this.btnAssembleProcessor = new System.Windows.Forms.Button();
            this.btnAssembleRam = new System.Windows.Forms.Button();
            this.btnAssemblePowerSource = new System.Windows.Forms.Button();
            this.btnAssembleGraphicCard = new System.Windows.Forms.Button();
            this.lblProductList = new System.Windows.Forms.Label();
            this.rtbCurrentAssembling = new System.Windows.Forms.RichTextBox();
            this.btnAssembleProduct = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblCurrentAssembling = new System.Windows.Forms.Label();
            this.lblSelectProductToAssemble = new System.Windows.Forms.Label();
            this.btnAssembleNotebook = new System.Windows.Forms.Button();
            this.btnCancelAssembling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListaProductos
            // 
            this.rtbListaProductos.Location = new System.Drawing.Point(12, 27);
            this.rtbListaProductos.Name = "rtbListaProductos";
            this.rtbListaProductos.Size = new System.Drawing.Size(434, 551);
            this.rtbListaProductos.TabIndex = 0;
            this.rtbListaProductos.Text = "";
            // 
            // btnAssemblePC
            // 
            this.btnAssemblePC.Location = new System.Drawing.Point(452, 51);
            this.btnAssemblePC.Name = "btnAssemblePC";
            this.btnAssemblePC.Size = new System.Drawing.Size(75, 23);
            this.btnAssemblePC.TabIndex = 1;
            this.btnAssemblePC.Text = "PC";
            this.btnAssemblePC.UseVisualStyleBackColor = true;
            this.btnAssemblePC.Click += new System.EventHandler(this.btnEnsamblarPC_Click);
            // 
            // btnAssembleMotherboard
            // 
            this.btnAssembleMotherboard.Location = new System.Drawing.Point(510, 109);
            this.btnAssembleMotherboard.Name = "btnAssembleMotherboard";
            this.btnAssembleMotherboard.Size = new System.Drawing.Size(87, 23);
            this.btnAssembleMotherboard.TabIndex = 4;
            this.btnAssembleMotherboard.Text = "Motherboard";
            this.btnAssembleMotherboard.UseVisualStyleBackColor = true;
            this.btnAssembleMotherboard.Click += new System.EventHandler(this.btnAssembleMotherboard_Click);
            // 
            // lblSelectComponents
            // 
            this.lblSelectComponents.AutoSize = true;
            this.lblSelectComponents.Location = new System.Drawing.Point(452, 93);
            this.lblSelectComponents.Name = "lblSelectComponents";
            this.lblSelectComponents.Size = new System.Drawing.Size(199, 13);
            this.lblSelectComponents.TabIndex = 5;
            this.lblSelectComponents.Text = "Select the components for the computer:";
            // 
            // btnAssembleProcessor
            // 
            this.btnAssembleProcessor.Location = new System.Drawing.Point(510, 138);
            this.btnAssembleProcessor.Name = "btnAssembleProcessor";
            this.btnAssembleProcessor.Size = new System.Drawing.Size(87, 23);
            this.btnAssembleProcessor.TabIndex = 6;
            this.btnAssembleProcessor.Text = "Processor";
            this.btnAssembleProcessor.UseVisualStyleBackColor = true;
            this.btnAssembleProcessor.Click += new System.EventHandler(this.btnAssembleProcessor_Click);
            // 
            // btnAssembleRam
            // 
            this.btnAssembleRam.Location = new System.Drawing.Point(510, 167);
            this.btnAssembleRam.Name = "btnAssembleRam";
            this.btnAssembleRam.Size = new System.Drawing.Size(87, 23);
            this.btnAssembleRam.TabIndex = 7;
            this.btnAssembleRam.Text = "RAM";
            this.btnAssembleRam.UseVisualStyleBackColor = true;
            this.btnAssembleRam.Click += new System.EventHandler(this.btnAssembleRam_Click);
            // 
            // btnAssemblePowerSource
            // 
            this.btnAssemblePowerSource.Location = new System.Drawing.Point(510, 225);
            this.btnAssemblePowerSource.Name = "btnAssemblePowerSource";
            this.btnAssemblePowerSource.Size = new System.Drawing.Size(87, 23);
            this.btnAssemblePowerSource.TabIndex = 8;
            this.btnAssemblePowerSource.Text = "Power Source";
            this.btnAssemblePowerSource.UseVisualStyleBackColor = true;
            this.btnAssemblePowerSource.Click += new System.EventHandler(this.btnAssemblePowerSupply_Click);
            // 
            // btnAssembleGraphicCard
            // 
            this.btnAssembleGraphicCard.Location = new System.Drawing.Point(510, 196);
            this.btnAssembleGraphicCard.Name = "btnAssembleGraphicCard";
            this.btnAssembleGraphicCard.Size = new System.Drawing.Size(87, 23);
            this.btnAssembleGraphicCard.TabIndex = 9;
            this.btnAssembleGraphicCard.Text = "Graphic Card";
            this.btnAssembleGraphicCard.UseVisualStyleBackColor = true;
            this.btnAssembleGraphicCard.Click += new System.EventHandler(this.btnAssembleGraphicCard_Click);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(9, 11);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(63, 13);
            this.lblProductList.TabIndex = 10;
            this.lblProductList.Text = "Product List";
            // 
            // rtbCurrentAssembling
            // 
            this.rtbCurrentAssembling.Location = new System.Drawing.Point(657, 27);
            this.rtbCurrentAssembling.Name = "rtbCurrentAssembling";
            this.rtbCurrentAssembling.Size = new System.Drawing.Size(316, 551);
            this.rtbCurrentAssembling.TabIndex = 11;
            this.rtbCurrentAssembling.Text = "";
            // 
            // btnAssembleProduct
            // 
            this.btnAssembleProduct.Location = new System.Drawing.Point(486, 524);
            this.btnAssembleProduct.Name = "btnAssembleProduct";
            this.btnAssembleProduct.Size = new System.Drawing.Size(136, 23);
            this.btnAssembleProduct.TabIndex = 12;
            this.btnAssembleProduct.Text = "Assemble Product";
            this.btnAssembleProduct.UseVisualStyleBackColor = true;
            this.btnAssembleProduct.Click += new System.EventHandler(this.btnAssembleProduct_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(510, 291);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(87, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(507, 275);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Product description:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(507, 314);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 15;
            this.lblColor.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(510, 330);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(87, 20);
            this.txtColor.TabIndex = 16;
            // 
            // lblCurrentAssembling
            // 
            this.lblCurrentAssembling.AutoSize = true;
            this.lblCurrentAssembling.Location = new System.Drawing.Point(654, 11);
            this.lblCurrentAssembling.Name = "lblCurrentAssembling";
            this.lblCurrentAssembling.Size = new System.Drawing.Size(97, 13);
            this.lblCurrentAssembling.TabIndex = 17;
            this.lblCurrentAssembling.Text = "Current Assembling";
            // 
            // lblSelectProductToAssemble
            // 
            this.lblSelectProductToAssemble.AutoSize = true;
            this.lblSelectProductToAssemble.Location = new System.Drawing.Point(483, 35);
            this.lblSelectProductToAssemble.Name = "lblSelectProductToAssemble";
            this.lblSelectProductToAssemble.Size = new System.Drawing.Size(144, 13);
            this.lblSelectProductToAssemble.TabIndex = 3;
            this.lblSelectProductToAssemble.Text = "What you want to assemble?";
            // 
            // btnAssembleNotebook
            // 
            this.btnAssembleNotebook.Location = new System.Drawing.Point(576, 51);
            this.btnAssembleNotebook.Name = "btnAssembleNotebook";
            this.btnAssembleNotebook.Size = new System.Drawing.Size(75, 23);
            this.btnAssembleNotebook.TabIndex = 2;
            this.btnAssembleNotebook.Text = "Notebook";
            this.btnAssembleNotebook.UseVisualStyleBackColor = true;
            this.btnAssembleNotebook.Click += new System.EventHandler(this.btnAssembleNotebook_Click);
            // 
            // btnCancelAssembling
            // 
            this.btnCancelAssembling.Location = new System.Drawing.Point(486, 553);
            this.btnCancelAssembling.Name = "btnCancelAssembling";
            this.btnCancelAssembling.Size = new System.Drawing.Size(136, 23);
            this.btnCancelAssembling.TabIndex = 18;
            this.btnCancelAssembling.Text = "Cancel Assembling";
            this.btnCancelAssembling.UseVisualStyleBackColor = true;
            this.btnCancelAssembling.Click += new System.EventHandler(this.btnCancelAssembling_Click);
            // 
            // FrmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 590);
            this.Controls.Add(this.btnCancelAssembling);
            this.Controls.Add(this.lblCurrentAssembling);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAssembleProduct);
            this.Controls.Add(this.rtbCurrentAssembling);
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.btnAssembleGraphicCard);
            this.Controls.Add(this.btnAssemblePowerSource);
            this.Controls.Add(this.btnAssembleRam);
            this.Controls.Add(this.btnAssembleProcessor);
            this.Controls.Add(this.lblSelectComponents);
            this.Controls.Add(this.btnAssembleMotherboard);
            this.Controls.Add(this.lblSelectProductToAssemble);
            this.Controls.Add(this.btnAssembleNotebook);
            this.Controls.Add(this.btnAssemblePC);
            this.Controls.Add(this.rtbListaProductos);
            this.Name = "FrmFactory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmFactory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListaProductos;
        private System.Windows.Forms.Button btnAssemblePC;
        private System.Windows.Forms.Button btnAssembleMotherboard;
        private System.Windows.Forms.Label lblSelectComponents;
        private System.Windows.Forms.Button btnAssembleProcessor;
        private System.Windows.Forms.Button btnAssembleRam;
        private System.Windows.Forms.Button btnAssemblePowerSource;
        private System.Windows.Forms.Button btnAssembleGraphicCard;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.RichTextBox rtbCurrentAssembling;
        private System.Windows.Forms.Button btnAssembleProduct;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblCurrentAssembling;
        private System.Windows.Forms.Label lblSelectProductToAssemble;
        private System.Windows.Forms.Button btnAssembleNotebook;
        private System.Windows.Forms.Button btnCancelAssembling;
    }
}

