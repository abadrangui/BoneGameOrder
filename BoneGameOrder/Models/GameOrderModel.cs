using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoneGameOrder.Models
{
    public class GameOrderModel
    {
        public Guid ID { get; set; }
        public string RoomNo  {get; set;}
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}