using System.Text.RegularExpressions;

namespace AndreevAndreyKT_41_20.Models
{
    public class AcademGroup
    {
        public int AcademGroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        
        public bool IsValidGroupName() // Проверка формата ввода названия группы
        {
            return Regex.Match(GroupName, @"/\D*-\d*-\d\d/g").Success;
        }

    }
}
