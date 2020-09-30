using System.ComponentModel.DataAnnotations;

namespace JobsCatalog.Seeder
{
    public class JobData
    {
         public  string[] Tags {get;set;} = {"laravel,js,php,wampserver,ajax","vs-code,visual-studio,sqlserver,microsoft,aspnetn,azure","mongo,npm,react,node,express"
                  ,"commiication,english,hospitality"
                  ,"doctor,hospital,nurse","dbms,mysql,amazon,google,data-structure","agile,aws,software,sdlc,engineering","html,css,js,scss,bootstrap","sales,marketing,hr,interns","seo,email-marketing,facebook-ads,instagram-boost"};
         public  string[] JobTypes {get;set;} = {"FullTime", "PartTime", "Internship", "Remote", "Freelance" };
         public string[] JobLocations { get; set; } = {"Birtamode", "Kathmandu", "NewYork","Biratnagar","Bhadrapur"};
         public string[] JobCategories { get; set; } = {"IT","Construction","Engineering/Projects","Teaching","Manufacturing/Industrial","Real Estate","Sales","Quality check"};
        public string[] JobPosterUserIds { get; set; } = {"dab6f06c-72f8-4912-81b5-ebde1588c8be","dab6f06c-72f8-4912-81b5-ebde1518c8be","dab6f06c-72f8-4912-81b5-ebde1388c8be"};

        
    

        // public  JobCategory JobCategories{get;set;}
        // public  JobType JobTypes{get;set;}
        // public  JobLocation JobLocations{get;set;}
        
    }
}