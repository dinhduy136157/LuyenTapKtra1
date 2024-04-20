using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuyenTapKtra1.Models
{
    public class HocSinh
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Lop {  get; set; }
        public int diemToan {  get; set; }
        public int diemVan { get; set; }
        public int diemTk
        {
            get
            {
                return diemToan * diemVan;
            }
        }
        public HocSinh() { }
        public HocSinh(string id, string name, string lop, int diemtoan, int diemvan)
        {
            Id = id;
            Name = name;
            Lop = lop;
            diemToan = diemtoan;
            diemVan = diemvan;


        }
    }
}