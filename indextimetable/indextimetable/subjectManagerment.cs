using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indextimetable
{
    public class subjectManagerment
    {
        public List<Table> getSubject()
        {
            var db = new thoiKhoaBieuEntities2();
            List<Table> subject = db.Tables.ToList();
            return subject;
        }
        public Table getSubjects(int ID)
        {
            var db = new thoiKhoaBieuEntities2();
            var subject = db.Tables.Find(ID);
            return subject;
        }
        public void createSubject(string CaHoc , string thu2, string thu3,string thu4,string thu5,string thu6,string thu7)
        {
            var db = new thoiKhoaBieuEntities2();
            var newSubject = new Table();
            newSubject.CA_HỌC = CaHoc;
            newSubject.Thứ_2 = thu2;
            newSubject.Thứ_3 = thu3;
            newSubject.Thứ_4 = thu4;
            newSubject.Thứ_5 = thu5;
            newSubject.Thứ_6 = thu6;
            newSubject.Thứ_7 = thu7;
            db.Tables.Add(newSubject);
            db.SaveChanges();
        }
        public void updateSubject(int id, string CaHoc, string thu2, string thu3, string thu4, string thu5, string thu6, string thu7)
        {
            var db = new thoiKhoaBieuEntities2();
            var currentSubject = db.Tables.Find(CaHoc);
            currentSubject.CA_HỌC = CaHoc;
            currentSubject.Thứ_2 = thu2;
            currentSubject.Thứ_3 = thu3;
            currentSubject.Thứ_4 = thu4;
            currentSubject.Thứ_5 = thu5;
            currentSubject.Thứ_6 = thu6;
            currentSubject.Thứ_7 = thu7;
            db.Entry(currentSubject).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
