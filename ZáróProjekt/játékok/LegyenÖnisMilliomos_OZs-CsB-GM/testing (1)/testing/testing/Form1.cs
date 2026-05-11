using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace testing {
    public partial class Form1 : Form {

        //Alap Cuccok
        int currentQuestion, correctIndex, score;
        string currentSubject = "";
        List<int> questionOrder = new List<int>();
        Timer timer1;
        List<string> words = new List<string> { "korán", "Ki", "lel", "aranyat", "kel"};
        List<string> shuffledWords;
        int wordIndex = 0;
        int scoreFold, scoreTort, scoreMagyar, scoreMatek, scoreBiosz;

        //Form1 Inditas + Egyeb Kissebb Cuccok
        public Form1() {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            shuffledWords = words.OrderBy(x => Guid.NewGuid()).ToList();
            if (label1 == null) {
                label1 = new Label();
                label1.Location = new Point(20, 300);
                label1.Size = new Size(200, 30);
                this.Controls.Add(label1);
            }
        }

        //Publikus Valtozok
        public int keszvane = 0;
        public int idohatravan = 900;
        public System.Windows.Forms.Timer visszaszamlalo;

        //Idozito
        private void Visszaszamol()
        {
            visszaszamlalo = new System.Windows.Forms.Timer();
            visszaszamlalo.Interval = 1000;
            visszaszamlalo.Tick += vissza;
            visszaszamlalo.Start();
        }

        //Idozito
        private void vissza(object sender, EventArgs e)
        {
            idohatravan--;
            label2.Text = $"{idohatravan / 60}:{idohatravan % 60}";

            if (idohatravan == 0)
            {
                visszaszamlalo.Stop();
                MessageBox.Show("Lejárt az időd. Sajnos nem sikerült teljesítened időben a feladatokat.", "Sajnáljuk!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        //Valtozok Es Ertekek
        public void Kerdesek(string kerdes, string v1, string v2, string v3, string v4, int correct) {
            label1.Text = kerdes;
            button1.Text = v1;
            button2.Text = v2;
            button3.Text = v3;
            button4.Text = v4;
            correctIndex = correct;
        }

        //Kerdesek Random Kivalasztasa
        public void GenerateRandomOrder(int count) { 
            questionOrder = Enumerable.Range(0, count).OrderBy(x => Guid.NewGuid()).ToList(); 
        }

        //Kerdesek Es Valaszok
        public void LoadNextQuestion() {
            ResetButtonColors();
            if (currentSubject == "foldrajz") {
                if (currentQuestion >= 5) { scoreFold = score; EndQuiz(); return; }
                switch (questionOrder[currentQuestion]) {
                    case 0: Kerdesek("Melyik a világ legnagyobb óceánja?", "Atlanti-óceán", "Indiai-óceán", "Csendes-óceán", "Jeges-óceán", 2); break;
                    case 1: Kerdesek("Melyik ország fővárosa Nairobi?", "Nigéria", "Kenya", "Tanzánia", "Etiópia", 1); break;
                    case 2: Kerdesek("Melyik hegységben található a Mount Everest?", "Alpok", "Kárpátok", "Himalája", "Andok", 2); break;
                    case 3: Kerdesek("Melyik folyó szeli át Budapestet?", "Tisza", "Duna", "Maros", "Szajna", 1); break;
                    case 4: Kerdesek("Melyik országban található a Grand Canyon?", "Kanada", "Egyesült Államok", "Mexikó", "Brazília", 1); break;
                }
            }
            if (currentSubject == "tortenelem") {
                if (currentQuestion >= 5) { scoreTort = score; EndQuiz(); return; }
                switch (questionOrder[currentQuestion]) {
                    case 0: Kerdesek("Ki volt az első magyar király?", "Károly Róbert", "Szent István", "IV. Béla", "Mátyás király", 1); break;
                    case 1: Kerdesek("Mikor volt a mohácsi csata?", "1241", "1526", "1703", "1848", 1); break;
                    case 2: Kerdesek("Ki volt a francia forradalom híres jakobinus vezetője?", "Robespierre", "Napóleon", "Rousseau", "Voltaire", 0); break;
                    case 3: Kerdesek("Melyik évben tört ki a Magyar forradalom és szabadságharc?", "1848", "1867", "1914", "1958", 0); break;
                    case 4: Kerdesek("Ki volt az USA első elnöke?", "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams", 1); break;
                }
            }
            if (currentSubject == "magyar") {
                if (currentQuestion >= 5) { scoreMagyar = score; EndQuiz(); return; }
                switch (questionOrder[currentQuestion]) {
                    case 0: Kerdesek("Ki írta a 'Toldi' című művet?", "Petőfi Sándor", "Arany János", "Jókai Mór", "Ady Endre", 1); break;
                    case 1: Kerdesek("Melyik stílusirányzathoz tartozik Ady Endre?", "Klasszicizmus", "Szimbolizmus", "Realizmus", "Romantika", 1); break;
                    case 2: Kerdesek("Mi a 'szinonima' jelentése?", "Ellentétes jelentésű szó", "Azonos jelentésű szó", "Idegen eredetű szó", "Hangutánzó szó", 1); break;
                    case 3: Kerdesek("Ki volt a 'nemzet költője'?", "Petőfi Sándor", "Arany János", "Vörösmarty Mihály", "József Attila", 0); break;
                    case 4: Kerdesek("Melyik mű kezdődik így: 'Ég a napmelegtől a kopár szík sarja…'?", "Nemzeti dal", "Szózat", "Toldi", "Himnusz", 2); break;
                }
            }
            if (currentSubject == "matematika") {
                if (currentQuestion >= 5) { scoreMatek = score; EndQuiz(); return; }
                switch (questionOrder[currentQuestion]) {
                    case 0: Kerdesek("Mennyi 12 × 8?", "96", "88", "108", "86", 0); break;
                    case 1: Kerdesek("Mennyi a 144 gyöke?", "10", "11", "12", "13", 2); break;
                    case 2: Kerdesek("Mennyi 3² + 4²?", "25", "21", "19", "29", 0); break;
                    case 3: Kerdesek("Mennyi 1/2 + 1/3?", "5/6", "2/5", "1/6", "7/6", 0); break;
                    case 4: Kerdesek("Mennyi 200-nak a 15%-a?", "25", "30", "35", "40", 1); break;
                }
            }
            if (currentSubject == "biologia") {
                if (currentQuestion >= 5) { scoreBiosz = score; EndQuiz(); return; }
                switch (questionOrder[currentQuestion]) {
                    case 0: Kerdesek("Melyik szerv pumpálja a vért az emberi testben?", "Tüdő", "Máj", "Gyomor", "Szív", 3); break;
                    case 1: Kerdesek("Mit termelnek a növények fotoszintézis során?", "Szén-dioxidot", "Oxigént", "Hőt", "Nitrogént", 1); break;
                    case 2: Kerdesek("Mi a DNS fő szerepe?", "Energia termelése", "A sejtek mozgásának irányítása", "A vércukorszint szabályozása", "Genetikai információ tárolása", 3); break;
                    case 3: Kerdesek("Melyik állat tartozik az emlősök közé?", "Kígyó", "Varjú", "Delfin", "Béka", 2); break;
                    case 4: Kerdesek("Melyik tápanyag biztosít elsősorban energiát?", "Ásványi anyagok", "Szénhidrátok", "Vitaminok", "Víz", 1); break;
                }
            }
        }

        //A Quiz Temakoreinek Befejezese
        public void EndQuiz() {
            keszvane++;
            if (currentSubject == "foldrajz") scoreFold = score;
            if (currentSubject == "tortenelem") scoreTort = score;
            if (currentSubject == "magyar") scoreMagyar = score;
            if (currentSubject == "matematika") scoreMatek = score;
            if (currentSubject == "biologia") scoreBiosz = score;
            string currentWord = shuffledWords[wordIndex];
            label1.Text = currentWord;
            label1.Text = $"Pontszám: {score}/5 – {currentWord}";
            wordIndex++;
            if (wordIndex >= shuffledWords.Count) {
                shuffledWords = words.OrderBy(x => Guid.NewGuid()).ToList();
                wordIndex = 0;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (currentSubject == "tortenelem") { button5.Enabled = false; }
            if (currentSubject == "foldrajz") { button6.Enabled = false; }
            if (currentSubject == "magyar") { button7.Enabled = false; }
            if (currentSubject == "matematika") { button8.Enabled = false; }
            if (currentSubject == "biologia") { button10.Enabled = false; }

            if (keszvane == 5)
            {
                button9.Enabled = true;
            }
        }

        //Gombok Szinenek Visszaallitasa
        public void ResetButtonColors() {
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
        }

        //Helyes Valasz Vizsgalast
        public void CheckAnswer(int index) {
            Button[] b = { button1, button2, button3, button4 };
            if (index == correctIndex) {
                b[index].BackColor = Color.LightGreen;
                score++;
            }
            else {
                b[index].BackColor = Color.Red;
                b[correctIndex].BackColor = Color.LightGreen;
            } timer1.Enabled = true;
        }

        //Kello Pont Vizsgalasa
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; 
            if (currentQuestion < 4) 
                { currentQuestion++; LoadNextQuestion(); }
            else
                { if (score >= 4)
                    { EndQuiz(); } 
                else 
                    { currentQuestion = 0; score = 0; LoadNextQuestion(); MessageBox.Show("Nem érted el a kellő ponotszámot, előröl fogod kezdeni ezt a kérdéssort.");
                } 
            } 
        }

        //Quiz Inditasa
        public void StartQuiz() {
            currentQuestion = 0;
            score = 0;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = true;
            GenerateRandomOrder(5);
            LoadNextQuestion();
        }

        //A Negy Valasz Gomb
        private void button1_Click(object sender, EventArgs e) { CheckAnswer(0); }
        private void button2_Click(object sender, EventArgs e) { CheckAnswer(1); }
        private void button3_Click(object sender, EventArgs e) { CheckAnswer(2); }
        private void button4_Click(object sender, EventArgs e) { CheckAnswer(3); }

        //Program Betoltese
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Legyen Ön Is Milliomos - Diák Verzió";
            button1.Visible = button2.Visible = button3.Visible = button4.Visible = button5.Visible = button6.Visible = button7.Visible = button8.Visible = button9.Visible = button10.Visible = button11.Visible = false;
        }

        //Restart Button
        private void button11_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            idohatravan = 900;
            InitializeComponent();
            label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
            button12.Visible = false;
            keszvane = 0;
            score = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
            button12.Visible = false;
            button5.Visible = button6.Visible = button7.Visible = button8.Visible = button9.Visible = button10.Visible = button11.Visible = true;
            Visszaszamol();
        }

        //Themes Select Buttons
        private void button5_Click(object sender, EventArgs e) {
            currentSubject = "tortenelem";
            StartQuiz();
        }
        private void button6_Click(object sender, EventArgs e) {
            currentSubject = "foldrajz";
            StartQuiz();
        }
        private void button7_Click(object sender, EventArgs e) {
            currentSubject = "magyar";
            StartQuiz();
        }
        private void button8_Click(object sender, EventArgs e) {
            currentSubject = "matematika";
            StartQuiz();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            currentSubject = "biologia";
            StartQuiz();
        }

        //Finish Button
        private void button9_Click(object sender, EventArgs e) {
            int total = scoreFold + scoreTort + scoreMagyar + scoreMatek + scoreBiosz;
            string input = Interaction.InputBox("Írd be a 5 szót pontos sorrendben, szóközzel elválasztva:","Kód","");
            string correct = "Ki korán kel aranyat lel";
            if (input.Trim() == correct) { visszaszamlalo.Stop(); MessageBox.Show($"Helyes! Visszamaradt idod: {label2.Text}, Összpontszám: {total}/25"); this.Close(); }
            else { idohatravan -= 30; MessageBox.Show($"Hibás sorrend vagy hibás szó! - 30mp büntetés", "Figyelem!"); }
        }
    }
}