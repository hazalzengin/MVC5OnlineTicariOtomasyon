﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5OnlineTicariOtomasyon.Models.Classes
{
	public class Cari
	{
		[Key]
		public int CariId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string CariAd { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30,ErrorMessage ="En fazla 30 karakter yazabilirsiniz")]
		
		public string CariSoyad { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string CariUnvan { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(13)]
		public string CariSehir { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(50)]
		public string CariMail { get; set; }

		public bool Durum { get; set; }
		public ICollection<SatisHareket> SatisHarekets { get; set; }
	}
}