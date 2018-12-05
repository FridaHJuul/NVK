using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALRESTfulUtil.HttpClientJson;
using VenueServiceRequester.Model.JSON;
using VenueServiceRequester.Model.XML;

namespace VenueServiceRequester.Util.JSON
{
   public class VenueServiceUtilJSON
   {
      private string _portnumber, _hostname, _servicepath;
      private string _fullservicepath;

      public VenueServiceUtilJSON(string hostname, string portno, string servicepath)
      {
         _portnumber = portno;
         if (portno.Equals(""))
            _hostname = "http://" + hostname + "/";
         else _hostname = "http://" + hostname + ":" + portno + "/";
         _servicepath = servicepath + "/";
         _fullservicepath = _hostname + _servicepath;
      }

      public EquipmentCollection GetEquipment()
      {
         EquipmentCollection ec = new EquipmentCollection();
         APIGetJSONAsync<List<Equipment>> getEquipment = new APIGetJSONAsync<List<Equipment>>(this._fullservicepath+"ConcertEquipments");
         ec.equipments = getEquipment.data;
         return ec;
      }

      public Concerthall PostConcerthall(Concerthall concerthall)
      {
         APIPostJSON<Concerthall> postConcerthall = new APIPostJSON<Concerthall>(this._hostname,this._servicepath+ "ConcertHalls/", concerthall);
         return postConcerthall.data;
      }

      public Equipment PutEquipment(Equipment equipment)
      {
         APIPutJSON<Equipment> putEquipment = new APIPutJSON<Equipment>(this._hostname,this._servicepath + "ConcertEquipments/" + equipment.EquipmentId,equipment);
         return putEquipment.data;
      }
   }
}
