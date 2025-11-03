namespace RandomNumberGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            algorithm_choice = new ComboBox();
            label1 = new Label();
            length_of_number = new TextBox();
            seed_input = new TextBox();
            number_show = new TextBox();
            generate_button = new Button();
            SuspendLayout();
            // 
            // algorithm_choice
            // 
            algorithm_choice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            algorithm_choice.Font = new Font("Segoe UI", 12F);
            algorithm_choice.FormattingEnabled = true;
            algorithm_choice.Items.AddRange(new object[] { "Xorshift", "LFSR", "LCG" });
            algorithm_choice.Location = new Point(62, 123);
            algorithm_choice.Name = "algorithm_choice";
            algorithm_choice.Size = new Size(273, 40);
            algorithm_choice.TabIndex = 0;
            algorithm_choice.SelectedIndexChanged += algorithm_choice_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(566, 60);
            label1.TabIndex = 1;
            label1.Text = "Random Number Generator";
            // 
            // length_of_number
            // 
            length_of_number.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            length_of_number.Font = new Font("Segoe UI", 12F);
            length_of_number.Location = new Point(369, 124);
            length_of_number.Name = "length_of_number";
            length_of_number.PlaceholderText = "Length";
            length_of_number.Size = new Size(128, 39);
            length_of_number.TabIndex = 2;
            // 
            // seed_input
            // 
            seed_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            seed_input.Font = new Font("Segoe UI", 12F);
            seed_input.Location = new Point(526, 124);
            seed_input.Name = "seed_input";
            seed_input.PlaceholderText = "Seed";
            seed_input.Size = new Size(197, 39);
            seed_input.TabIndex = 3;
            // 
            // number_show
            // 
            number_show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            number_show.Font = new Font("Segoe UI", 12F);
            number_show.Location = new Point(62, 221);
            number_show.Name = "number_show";
            number_show.ReadOnly = true;
            number_show.Size = new Size(661, 39);
            number_show.TabIndex = 4;
            // 
            // generate_button
            // 
            generate_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            generate_button.BackgroundImageLayout = ImageLayout.Stretch;
            generate_button.Font = new Font("Segoe UI", 20F);
            generate_button.Location = new Point(62, 304);
            generate_button.Name = "generate_button";
            generate_button.Size = new Size(661, 67);
            generate_button.TabIndex = 5;
            generate_button.Text = "Generate";
            generate_button.UseVisualStyleBackColor = true;
            generate_button.Click += generate_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(794, 426);
            Controls.Add(generate_button);
            Controls.Add(number_show);
            Controls.Add(seed_input);
            Controls.Add(length_of_number);
            Controls.Add(label1);
            Controls.Add(algorithm_choice);
            Name = "Form1";
            Text = "RNG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox algorithm_choice;
        private Label label1;
        private TextBox length_of_number;
        private TextBox seed_input;
        private TextBox number_show;
        private Button generate_button;
    }
}
