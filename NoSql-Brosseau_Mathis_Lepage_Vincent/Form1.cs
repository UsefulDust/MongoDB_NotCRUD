using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NoSql_Brosseau_Mathis_Lepage_Vincent
{
    public partial class Form1 : Form
    {
        const string connectionUri = "mongodb://localhost:27017";
        MongoClient client = new MongoClient(connectionUri);
        IMongoDatabase db;


        public Form1()
        {
            db = client.GetDatabase("exemple");
            var joueurs = db.GetCollection<BsonDocument>("Joueurs");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", 2);
            Console.WriteLine(joueurs.Find(filter));

            InitializeComponent();
        }
    }
}
