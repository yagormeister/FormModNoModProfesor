
namespace FormModNoMod
{
    partial class Form1
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
            this.btAbrirModal = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnNoModal = new System.Windows.Forms.Button();
            this.lblModifica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAbrirModal
            // 
            this.btAbrirModal.Location = new System.Drawing.Point(152, 66);
            this.btAbrirModal.Name = "btAbrirModal";
            this.btAbrirModal.Size = new System.Drawing.Size(132, 23);
            this.btAbrirModal.TabIndex = 0;
            this.btAbrirModal.Text = "Abrir form modal";
            this.btAbrirModal.UseVisualStyleBackColor = true;
            this.btAbrirModal.Click += new System.EventHandler(this.btAbrirModal_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(312, 71);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(33, 13);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "antes";
            // 
            // btnNoModal
            // 
            this.btnNoModal.Location = new System.Drawing.Point(91, 149);
            this.btnNoModal.Name = "btnNoModal";
            this.btnNoModal.Size = new System.Drawing.Size(193, 23);
            this.btnNoModal.TabIndex = 2;
            this.btnNoModal.Text = "Abrir form No Modal";
            this.btnNoModal.UseVisualStyleBackColor = true;
            this.btnNoModal.Click += new System.EventHandler(this.btnNoModal_Click);
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifica.Location = new System.Drawing.Point(289, 149);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(140, 42);
            this.lblModifica.TabIndex = 3;
            this.lblModifica.Text = "Magia!!";
            this.lblModifica.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.lblModifica);
            this.Controls.Add(this.btnNoModal);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btAbrirModal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAbrirModal;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnNoModal;
        private System.Windows.Forms.Label lblModifica;
    }
}

