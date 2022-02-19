namespace RegistroEstudiantes
{
    partial class RegistroEstudiante
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosComboBox = new System.Windows.Forms.ComboBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LeerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // DatosComboBox
            // 
            this.DatosComboBox.FormattingEnabled = true;
            this.DatosComboBox.Location = new System.Drawing.Point(74, 235);
            this.DatosComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DatosComboBox.Name = "DatosComboBox";
            this.DatosComboBox.Size = new System.Drawing.Size(513, 23);
            this.DatosComboBox.TabIndex = 3;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(499, 59);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 27);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar.";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(247, 59);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(185, 21);
            this.NombreTextBox.TabIndex = 5;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(247, 111);
            this.EdadTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(185, 21);
            this.EdadTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datos Almacenados:";
            // 
            // LeerButton
            // 
            this.LeerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeerButton.Location = new System.Drawing.Point(499, 111);
            this.LeerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LeerButton.Name = "LeerButton";
            this.LeerButton.Size = new System.Drawing.Size(88, 27);
            this.LeerButton.TabIndex = 9;
            this.LeerButton.Text = "Leer.";
            this.LeerButton.UseVisualStyleBackColor = true;
            this.LeerButton.Click += new System.EventHandler(this.LeerButton_Click);
            // 
            // RegistroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 355);
            this.Controls.Add(this.LeerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DatosComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistroEstudiante";
            this.Text = "Registro de Estudiantes.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DatosComboBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LeerButton;
    }
}

