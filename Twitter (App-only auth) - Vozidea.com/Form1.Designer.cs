namespace Twitter__App_only_auth____Vozidea.com
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_go = new System.Windows.Forms.Button();
            this.textBox_json = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_consumer = new System.Windows.Forms.TextBox();
            this.textBox_secret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(377, 297);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 23);
            this.button_go.TabIndex = 0;
            this.button_go.Text = "GO!";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // textBox_json
            // 
            this.textBox_json.Location = new System.Drawing.Point(12, 84);
            this.textBox_json.Multiline = true;
            this.textBox_json.Name = "textBox_json";
            this.textBox_json.Size = new System.Drawing.Size(440, 207);
            this.textBox_json.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consumer key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumer secret";
            // 
            // textBox_consumer
            // 
            this.textBox_consumer.Location = new System.Drawing.Point(92, 6);
            this.textBox_consumer.Name = "textBox_consumer";
            this.textBox_consumer.Size = new System.Drawing.Size(360, 20);
            this.textBox_consumer.TabIndex = 4;
            this.textBox_consumer.Text = "gfHzxUdtcMKHEGC1whKeag";
            // 
            // textBox_secret
            // 
            this.textBox_secret.Location = new System.Drawing.Point(104, 32);
            this.textBox_secret.Name = "textBox_secret";
            this.textBox_secret.Size = new System.Drawing.Size(348, 20);
            this.textBox_secret.TabIndex = 5;
            this.textBox_secret.Text = "F75x0WXnmXosWX3yClZYIqZEat8rxivAR3b8dPsJlvk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario de Twitter";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(111, 58);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(341, 20);
            this.textBox_user.TabIndex = 7;
            this.textBox_user.Text = "Vozidea";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 332);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_secret);
            this.Controls.Add(this.textBox_consumer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_json);
            this.Controls.Add(this.button_go);
            this.Name = "Form1";
            this.Text = "Twitter (Application-only authentication) - Vozidea.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.TextBox textBox_json;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_consumer;
        private System.Windows.Forms.TextBox textBox_secret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_user;
    }
}

