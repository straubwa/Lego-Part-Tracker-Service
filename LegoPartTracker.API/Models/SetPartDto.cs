﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LegoPartTracker.API.Models
{
    public class SetPartDto
    {
        public int Id { get; set; }

        public string PartNumber { get; set; }

        public string Name { get; set; }

        public string PartUrl { get; set; }

        public string PartImageUrl { get; set; }

        public string Color { get; set; }

        public int QuantityNeeded { get; set; }

        public int QuantityFound { get; set; }

        public int QuantityRemaining { get; set; }

        public string ElementId { get; set; }
    }
}

  // code from rebrickable api

  //"count": 140,
  //"next": "https://rebrickable.com/api/v3/lego/sets/70611-1/parts/?page=2",
  //"previous": null,
  //"results": [
  //  {
  //    "id": 1244791,
  //    "inv_part_id": 1244791,
  //    "part": {
  //      "part_num": "63965",
  //      "name": "Bar 6L with Stop Ring",
  //      "part_url": "https://rebrickable.com/parts/63965/bar-6l-with-stop-ring/",
  //      "part_img_url": "https://m.rebrickable.com/media/parts/elements/4533907.jpg",
  //    },
  //    "color": {
  //      "name": "Black"
  //    },
  //    "quantity": 3,
  //    "element_id": "6081988"
  //  }
