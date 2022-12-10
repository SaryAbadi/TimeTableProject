using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.ModelsDto;

namespace BLL
{
   public class TeacherService
        
    {
        static teacher
        public TeacherService()
        {
            

        }
        public List<TeacherDto> GetMembers()
        {
            return <List<Teacherdto>>();
        }

        public TeacherDto GetMemberById(string id)
        {
            return mapperConfig.Map<Membersdto>(teachers.Find(m => m.MemberId == id).ToList().FirstOrDefault());
        }

        public void AddTeacher(TeacherDto teacher)
        {
            members.InsertOne(mapperConfig.Map<Members>(member));
        }

        public void UpdateTeacher(TeacherDto teacher)
        {
            var a = mapperConfig.Map<Members>(member);

            teachers.ReplaceOne(t => t.MemberId == member.MemberId, a);
        }

        public void DeleteTeacher(string id)
        {
            teachers.DeleteOne(m => m.MemberId == id);
        }
    }
}
