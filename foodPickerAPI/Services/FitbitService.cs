using foodPicker.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace foodPicker.Services
{
    public class FitbitService
    {
        public FitbitDataEntry[] Whatever_DB { get; set; }
        private JsonLoadService fitbitJsonLoadService;
        public FitbitService()
        {
            //var json = new JsonLoadService();
            fitbitJsonLoadService = new JsonLoadService();
            Whatever_DB = fitbitJsonLoadService.GetJson<FitbitDataEntry[]>(@"Database/db.json");
        }

        public FitbitDataEntry[] GetBolongo()
        {
            return fitbitJsonLoadService.GetJson<FitbitDataEntry[]>(@"Database/db.json");
            /*var Recepten = new List<Recept>();

            foreach (var recept in Whatever_DB.Recepten)
            {
                var NewRecept = new Recept();
                NewRecept.Id = recept.Id;
                NewRecept.ReceptNaam = recept.ReceptNaam;
                NewRecept.BenodigdeIngredienten = new List<Ingredient>();

                foreach (var id in recept.BenodigdeIngredienten)
                {
                    //NewRecept.BenodigdeIngredienten.Add(Whatever_DB.Ingredienten[id])
                    NewRecept.BenodigdeIngredienten.Add(Whatever_DB.Ingredienten.Single(x => x.Id == id));

                }

                Recepten.Add(NewRecept);
            }
            return Recepten;*/
            //Whatever_DB.Recepten[].ReceptNaam
        }

        public void addFitbitRecordToDB(FitbitDataEntry dataFromFitbit)
        {

            // date, AlarmDuration
            FitbitDataEntry[] dataFromDB = fitbitJsonLoadService.GetJson<FitbitDataEntry[]>(@"Database/db.json");

            var dbEntries = new List<FitbitDataEntry>();

            foreach (var dbEntry in dataFromDB)
            {
                dbEntries.Add(dbEntry);
            }

            dbEntries.Add(dataFromFitbit);

/*            new FitbitDataEntry[] = new newBolongoArray[dbEntries.Count];
            foreach (var listEntry in dbEntries)
            {

            }*/

            string newStringJsonDB = JsonConvert.SerializeObject(dbEntries);

            StreamWriter w = new StreamWriter(@"Database/db.json");
            w.Write(newStringJsonDB);
            w.Close();
            // nieuwe data = dataFomDB.Add(dataFromFitbit)
            // nieuwe json string = serialize json.db(nieuwe data)
            // db.json = nieuw string
        }


    }
}
