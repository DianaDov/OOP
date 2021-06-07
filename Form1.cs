using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;

        public static Form1 GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Form1();
            }
            return _instance;
        }
        public PlanetSystem system = new PlanetSystem();
        NewObjectForm newBodyForm;
        public EncryptForm encryptForm;
        public DectyptForm decryptForm;
        BindingList<AstronomicalObject> _dataSource;
        Serialization serialization = new Serialization();
        private Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dataSource = new BindingList<AstronomicalObject>(system.astronomicalObjects);
            listBox1.DataSource = _dataSource;
            listBox1.DisplayMember = "Name";
            classBox.DataSource = Enum.GetValues(typeof(StarClass));
            classBox.DropDownStyle = ComboBoxStyle.DropDownList;
            saveFileDialog1.Filter = "Binary files (*.bin)|*.bin|Xml files (*.xml)|*.xml|Text files (*.txt)|*.txt";
            openFileDialog1.Filter = "Binary files (*.bin)|*.bin|Xml files (*.xml)|*.xml|Text files (*.txt)|*.txt";
            comaRadiusBox.Hide();
            label22.Hide();
            hideAll();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            newBodyForm = new NewObjectForm();
            newBodyForm.okButton.Click += newObject;
            newBodyForm.Show();
        }
        private void newObject(object sender, EventArgs e)
        {
            if (newBodyForm.textBox1.Text == "")
            {
                MessageBox.Show("Поле названия должно быть заполнено", "Внимание");
                return;
            }
            String name = newBodyForm.textBox1.Text;
            AstronomicalObject astronomical;
            switch (newBodyForm.classBox.SelectedItem)
            {
                case "Газовый гигант":
                    astronomical = new GasGiant();
                    astronomical.Name = name;
                    showGasGiant((GasGiant)astronomical);
                    break;
                case "Звезда":
                    astronomical = new Star();
                    astronomical.Name = name;
                    showStar((Star)astronomical);
                    break;
                case "Комета":
                    astronomical = new Comet();
                    astronomical.Name = name;
                    showComet((Comet)astronomical);
                    break;
                case "Планета":
                default:
                    astronomical = new Planet();
                    astronomical.Name = name;
                    showPlanet((Planet)astronomical);
                    break;
            }

            _dataSource.Add((AstronomicalObject)astronomical);
            listBox1.SelectedIndex =_dataSource.IndexOf(astronomical);
            newBodyForm.Close();
        }
        private void showPanels()
        {
            hideAll();
            switch (listBox1.SelectedItem)
            {
                case GasGiant gasGiant:
                    showGasGiant(gasGiant);
                    break;
                case Star star:
                    showStar(star);
                    break;
                case Comet comet:
                    showComet(comet);
                    break;
                case Planet planet:
                    showPlanet(planet);
                    break;
            }
        }
        private void showGeneral(AstronomicalObject astronomicalObject)
        {
            nameBox.Text = astronomicalObject.Name;
            massBox.Text = astronomicalObject.Mass.ToString();
            posXBox.Text = astronomicalObject.position.X.ToString();
            posYBox.Text = astronomicalObject.position.Y.ToString();
            posZBox.Text = astronomicalObject.position.Z.ToString();
            velXBox.Text = astronomicalObject.velocity.X.ToString();
            velYBox.Text = astronomicalObject.velocity.Y.ToString();
            velZBox.Text = astronomicalObject.velocity.Z.ToString();
            generalPanel.Show();
            okButton.Show();
            deleteButton.Show();
        }
        private void showPlanet(Planet planet)
        {
            showGeneral(planet);
            planetRadiusBox.Text = planet.Radius.ToString();
            planetPanel.Show();
        }
        private void showGasGiant(GasGiant gasGiant)
        {
            showPlanet(gasGiant);
            liquidLayerRadiusBox.Text = gasGiant.LiquidLayerRadius.ToString();
            coreRadiusBox.Text = gasGiant.CoreRadius.ToString();
            gasGiantPanel.Show();
        }
        private void showStar(Star star)
        {
            showPlanet(star);
            temberatureBox.Text = star.Temperature.ToString();
            classBox.SelectedItem = star.starClass;
            starPanel.Show();
        }
        private void showComet(Comet comet)
        {
            showGeneral(comet);
            tailBox.Text = comet.TailLength.ToString();
            comaBox.Checked = comet.coma != null;
            if (comet.coma != null)
            {
                comaRadiusBox.Text = comet.coma.Radius.ToString();
            }
            cometPanel.Show();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem)
            {
                case GasGiant gasGiant:
                    fillGasGiant(gasGiant);
                    break;
                case Star star:
                    fillStar(star);
                    break;
                case Comet comet:
                    fillComet(comet);
                    break;
                case Planet planet:
                    fillPlanet(planet);
                    break;
            }
            hideAll();
        }
        private void fillGeneral(AstronomicalObject astronomical)
        {
            astronomical.Name = nameBox.Text;
            astronomical.Mass = double.Parse(massBox.Text);
            astronomical.position = new Vector3(double.Parse(posXBox.Text), double.Parse(posYBox.Text), double.Parse(posZBox.Text));
            astronomical.velocity = new Vector3(double.Parse(velXBox.Text), double.Parse(velYBox.Text), double.Parse(velZBox.Text));
        }
        private void fillPlanet(Planet planet)
        {
            fillGeneral(planet);
            planet.Radius = double.Parse(planetRadiusBox.Text);
        }
        private void fillGasGiant(GasGiant gasGiant)
        {
            fillPlanet(gasGiant);
            gasGiant.LiquidLayerRadius = double.Parse(liquidLayerRadiusBox.Text);
            gasGiant.CoreRadius = double.Parse(coreRadiusBox.Text);
        }
        private void fillStar(Star star)
        {
            fillPlanet(star);
            star.Temperature = double.Parse(temberatureBox.Text);
            star.starClass = (StarClass)classBox.SelectedItem;
        }
        private void fillComet(Comet comet)
        {
            fillGeneral(comet);
            comet.TailLength = double.Parse(tailBox.Text);
            comet.coma = comaBox.Checked ? (comet.coma == null ? new Coma() : comet.coma) : null;
            if (comaBox.Checked) comet.coma.Radius = double.Parse(comaBox.Text);
        }
        private void hideAll()
        {
            generalPanel.Hide();
            planetPanel.Hide();
            gasGiantPanel.Hide();
            starPanel.Hide();
            cometPanel.Hide();
            okButton.Hide();
            deleteButton.Hide();
        }
        private void restrictNonDigits(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.');
            e.Handled |= e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.');
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            _dataSource.Remove((AstronomicalObject)listBox1.SelectedItem);
            showPanels();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            switch (fileName.Substring(fileName.IndexOf(".") + 1))
            {
                case "bin":
                    serialization.serializeBinary();
                    break;
                case "xml":
                    serialization.serializeXml();
                    break;
                case "txt":
                    serialization.serializeText();
                    break;
            }
            encryptForm.Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            encryptForm = new EncryptForm();
            encryptForm.okButton.Click += encryptButton_Click;
            encryptForm.comboBox1.Items.Clear();
            encryptForm.comboBox1.Items.Add("Без шифрования");
            encryptForm.comboBox1.SelectedIndex = 0;
            serialization.refreshPlugins();
            encryptForm.Show();
        }
        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (encryptForm.keyBox.Text == "" && encryptForm.comboBox1.SelectedIndex != 0)
            {
                MessageBox.Show("Поле ключа должно быть заполнено", "Внимание");
                return;
            }
            saveFileDialog1.ShowDialog();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPanels();
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            decryptForm = new DectyptForm();
            decryptForm.button1.Click += decryptFormButton_Click;
            decryptForm.Show();
        }
        private void decryptFormButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;
            switch (fileName.Substring(fileName.IndexOf(".") + 1))
            {
                case "bin":
                    serialization.deserializeBinary();
                    break;
                case "xml":
                    serialization.deserializeXml();
                    break;
                case "txt":
                    serialization.deserializeText();
                    break;
            }
            _dataSource = new BindingList<AstronomicalObject>(system.astronomicalObjects);
            listBox1.DataSource = _dataSource;
            decryptForm.Close();
        }
        private void comaBox_CheckedChanged(object sender, EventArgs e)
        {
            if (comaBox.Checked)
            {
                comaRadiusBox.Show(); label22.Show();
            }
            else
            {
                comaRadiusBox.Hide(); label22.Hide();
            }
        }
    }
}
