using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        bool InsertModeDocument = true;
        bool InsertModePosition = true;

        public MainForm()
        {
            InitializeComponent();

            lGitHubInfo.Text = GetTextAsync("user-agent", "tomislav21", "Warehouse").Result;
        }

        public async Task<string> GetTextAsync(string userAgent, string userName, string repoName)
        {
            string text = "";
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(userAgent, repoName);
            string msg = string.Format("https://api.github.com/repos/{0}/{1}", userName, repoName);
            try
            {
                string jsonString = await httpClient.GetAsync(msg).Result.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(jsonString);
                string login = (string)jObject.SelectToken("owner.login");
                int stargazersCount = (int)jObject.SelectToken("stargazers_count");
                DateTime createdAt = (DateTime)jObject.SelectToken("created_at");
                text = string.Format("Dane z GitHUB | Nazwa użytownika: {0}, Ocena: {1}, Data utworzenia repozytorium: {2}", login, stargazersCount, createdAt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return text;
        }

        private void warehouse_dbDataSet1_Initialized(object sender, EventArgs e)
        {
            try
            {
                documentsTableAdapter1.SelectProc(warehouse_dbDataSet1.documents);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDocuments_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.Rows.Count != 0)
            {
                if (dgvDocuments.CurrentRow.Index != -1)
                {
                    InsertModeDocument = false;
                    btnInsertOrUpdateDocument.Text = "Zapisz zmiany";

                    dtpDateDocument.Value = Convert.ToDateTime(dgvDocuments.CurrentRow.Cells[1].Value.ToString());
                    nudClientNumberDocument.Value = Convert.ToInt32(dgvDocuments.CurrentRow.Cells[2].Value.ToString());
                    tbNameDocument.Text = dgvDocuments.CurrentRow.Cells[3].Value.ToString();

                    try
                    {
                        positionsTableAdapter1.SelectProc(this.warehouse_dbDataSet.positions, Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (dgvPositions.Rows.Count != 0)
                    {
                        InsertModePosition = false;
                        btnInsertOrUpdatePosition.Text = "Zapisz zmiany";

                        tbNamePosition.Text = dgvPositions.CurrentRow.Cells[2].Value.ToString();
                        nudQuantityPosition.Value = Convert.ToDecimal(dgvPositions.CurrentRow.Cells[3].Value.ToString());
                        nudNetPricePosition.Value = Convert.ToDecimal(dgvPositions.CurrentRow.Cells[4].Value.ToString());
                        nudGrossPricePosition.Value = Convert.ToDecimal(dgvPositions.CurrentRow.Cells[5].Value.ToString());
                    }
                }
            }
        }

        private void btnDeleteDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć wskazany dokument?", "Usuwanie dokumentu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    documentsTableAdapter1.DeleteProc(Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value.ToString()));
                    documentsTableAdapter1.SelectProc(warehouse_dbDataSet1.documents);
                    positionsTableAdapter1.SelectProc(this.warehouse_dbDataSet.positions, -1);
                    InsertModeDocument = true;
                    btnInsertOrUpdateDocument.Text = "Dodaj nowy";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertModeDocument)
                {
                    documentsTableAdapter1.InsertProc(dtpDateDocument.Value, Convert.ToInt32(nudClientNumberDocument.Value), tbNameDocument.Text);
                }
                else
                {
                    if (MessageBox.Show("Czy jesteś pewien, że chcesz zmienić dane we wskazanym dokumencie?", "Zmiana danych w dokumencie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        documentsTableAdapter1.UpdateProc(dtpDateDocument.Value, Convert.ToInt32(nudClientNumberDocument.Value), tbNameDocument.Text, Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value.ToString()));
                    }
                    else
                    {
                        return;
                    }
                }
                documentsTableAdapter1.SelectProc(warehouse_dbDataSet1.documents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearFormDocument_Click(object sender, EventArgs e)
        {
            btnInsertOrUpdateDocument.Text = "Dodaj nowy";
            dtpDateDocument.Value = DateTime.Now;
            nudClientNumberDocument.Value = 0;
            tbNameDocument.Text = "";
            InsertModeDocument = true;
        }

        private void dgvPositions_Click(object sender, EventArgs e)
        {
            if (dgvPositions.Rows.Count != 0)
            {
                if (dgvPositions.CurrentRow.Index != -1)
                {
                    InsertModePosition = false;
                    btnInsertOrUpdatePosition.Text = "Zapisz zmiany";

                    tbNamePosition.Text = dgvPositions.CurrentRow.Cells[2].Value.ToString();
                    nudQuantityPosition.Value = Convert.ToDecimal(dgvPositions.CurrentRow.Cells[3].Value.ToString());
                    nudNetPricePosition.Value = Convert.ToDecimal(dgvPositions.CurrentRow.Cells[4].Value.ToString());
                    nudGrossPricePosition.Value = Convert.ToDecimal(dgvPositions.CurrentRow.Cells[5].Value.ToString());
                }
            }
        }

        private void btnInsertOrUpdatePosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertModePosition)
                {
                    positionsTableAdapter1.InsertProc(Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value.ToString()), tbNamePosition.Text, Convert.ToInt32(nudQuantityPosition.Value), nudNetPricePosition.Value, nudGrossPricePosition.Value);
                }
                else
                {
                    if (MessageBox.Show("Czy jesteś pewien, że chcesz zmienić dane we wskazanej pozycji?", "Zmiana danych w pozycji", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        positionsTableAdapter1.UpdateProc(tbNamePosition.Text, Convert.ToInt32(nudQuantityPosition.Value), nudNetPricePosition.Value, nudGrossPricePosition.Value, Convert.ToInt32(dgvPositions.CurrentRow.Cells[0].Value.ToString()));
                    }
                    else
                    {
                        return;
                    }
                }
                documentsTableAdapter1.SelectProc(warehouse_dbDataSet1.documents);
                positionsTableAdapter1.SelectProc(this.warehouse_dbDataSet.positions, Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value.ToString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearFormPosition_Click(object sender, EventArgs e)
        {
            btnInsertOrUpdatePosition.Text = "Dodaj nową";
            tbNamePosition.Text = "";
            nudQuantityPosition.Value = 0;
            nudNetPricePosition.Value = 0;
            nudGrossPricePosition.Value = 0;
            InsertModePosition = true;
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć wskazaną pozycję?", "Usuwanie pozycji", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    positionsTableAdapter1.DeleteProc(Convert.ToInt32(dgvPositions.CurrentRow.Cells[0].Value.ToString()));
                    documentsTableAdapter1.SelectProc(warehouse_dbDataSet1.documents);
                    InsertModePosition = true;
                    btnInsertOrUpdatePosition.Text = "Dodaj nowy";

                    documentsTableAdapter1.SelectProc(warehouse_dbDataSet1.documents);
                    positionsTableAdapter1.SelectProc(this.warehouse_dbDataSet.positions, Convert.ToInt32(dgvDocuments.CurrentRow.Cells[0].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
