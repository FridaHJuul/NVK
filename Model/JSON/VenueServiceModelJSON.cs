using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenueServiceRequester.Model.JSON
{
   public class EquipmentCollection
   {
      public List<Equipment> equipments { get; set; }
   }

   public class Equipment
   {
      public int EquipmentId { get; set; }
      public string EquipmentName { get; set; }
      public string Description { get; set; }
      public string FactoryName { get; set; }
      public int EquipmentCount { get; set; }
      public string BelongsToConcertHall { get; set; }
   }


   public class ConcerthallCollection
   {
      public List<Concerthall> concerthalls { get; set; }
   }

   public class Concerthall
   {
      public int ConcertHallId { get; set; }
      public string ConcertHallName { get; set; }
      public string IsLocatatVenue { get; set; }
      public string HallResponsible { get; set; }
      public float HallsizeM2 { get; set; }
      public float StagesizeM2 { get; set; }
      public int MaxNoAudience { get; set; }
      public int NoOfDoors { get; set; }
      public List<Equipment> Equipment { get; set; }
   }

}
