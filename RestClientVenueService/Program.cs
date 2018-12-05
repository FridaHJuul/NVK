using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueServiceRequester.Model.JSON;
using VenueServiceRequester.Util.JSON;

namespace RestClientVenueService
{
   class Program
   {
      static void Main(string[] args)
      {
         VenueServiceUtilJSON venueServiceUtilJson = new VenueServiceUtilJSON("venueserviceaseece.azurewebsites.net","", "venueservice");
         
         //Test af GetEquipment
         EquipmentCollection equipmentCollection = venueServiceUtilJson.GetEquipment();
         //Testet og det virker

         //Test af post ConcertHall 
         //Concerthall concerthall = new Concerthall();
         //concerthall.ConcertHallId = 21;
         //concerthall.ConcertHallName = "Det Nye Teater";
         //concerthall.IsLocatatVenue = "København";
         //concerthall.HallResponsible = "Børge Simonsen";
         //concerthall.HallsizeM2 = 210;
         //concerthall.StagesizeM2 = 21;
         //concerthall.MaxNoAudience = 210;
         //concerthall.NoOfDoors = 7;

         //List<Equipment> equipmentCollection2 = new List<Equipment>();
         //Equipment scene = new Equipment();
         //scene.EquipmentName = "scene";
         //scene.BelongsToConcertHall = "Det Nye Teater";
         //scene.EquipmentCount = 1;
         //scene.EquipmentId = 21;
         //scene.FactoryName = "Håndværksskolen";
         //equipmentCollection2.Add(scene);

         //concerthall.Equipment = equipmentCollection2;
         //venueServiceUtilJson.PostConcerthall(concerthall);
         //Testet og det virker (se hjemmeside med XML)

         //Der SKAL i følge opgaven laves to concerthalls - gøres nu:
         //Concerthall concerthall2 = new Concerthall();
         //List<Equipment> equipments = new List<Equipment>();
         //Equipment scenelys = new Equipment();
         //scenelys.EquipmentId = 321;
         //scenelys.BelongsToConcertHall = "House of Art";
         //scenelys.EquipmentCount = 5;
         //scenelys.EquipmentName = "scenelys";
         //scenelys.FactoryName = "Lysmesteren";
         //equipments.Add(scenelys);
         //equipments.Add(scene);
         //concerthall2.Equipment = equipments;
         //concerthall2.ConcertHallId = 321;
         //concerthall2.ConcertHallName = "House of Art";
         //concerthall2.HallResponsible = "James Williams";
         //concerthall2.HallsizeM2 = 3214;
         //concerthall2.IsLocatatVenue = "New York";
         //concerthall2.MaxNoAudience = 3000;
         //concerthall2.NoOfDoors = 32;
         //concerthall2.StagesizeM2 = 30;
         //venueServiceUtilJson.PostConcerthall(concerthall2);
         //Testet og det virker

         //Test af putEquipment
         Equipment gardin = new Equipment();
         gardin.EquipmentId = 2;
         gardin.BelongsToConcertHall = "Det Nye Teater";
         gardin.EquipmentCount = 1;
         gardin.EquipmentName = "Gardin";
         gardin.FactoryName = "Stof og stil";
         venueServiceUtilJson.PutEquipment(gardin);
         //Virker!!!

         //Skal gøres for 4 equipment tilknyttes til 2 koncerthuse




      }
   }
}
