using Microsoft.EntityFrameworkCore;
using static Pensionsberegner.CalculatorClasses;

namespace Pensionsberegner.Models
{
    public partial class PContext : DbContext
    {
        public PContext(DbContextOptions<PContext> options) : base(options)
        {
            
        }
        public virtual DbSet<Rootobject> Rootobject { get; set; }
        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Paths> Paths { get; set; }
        public virtual DbSet<ApiLicense> ApiLicense { get; set; }
        public virtual DbSet<Put> Put { get; set; }
        public virtual DbSet<Responses> Responses { get; set; }
        public virtual DbSet<_200> _200 { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<TextPlain> TextPlain { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<ApplicationJson> ApplicationJson { get; set; }
        public virtual DbSet<Schema1> Schema1 { get; set; }
        public virtual DbSet<TextJson> TextJson { get; set; }
        public virtual DbSet<Schema2> Schema2 { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Schema3> Schema3 { get; set; }
        public virtual DbSet<ApiPublicpension> ApiPublicpension { get; set; }
        public virtual DbSet<Put1> Put1 { get; set; }
        public virtual DbSet<Requestbody> Requestbody { get; set; }
        public virtual DbSet<Content1> Content1 { get; set; }
        public virtual DbSet<ApplicationJson1> ApplicationJson1 { get; set; }
        public virtual DbSet<Schema4> Schema4 { get; set; }
        public virtual DbSet<TextJson1> TextJson1 { get; set; }
        public virtual DbSet<Schema5> Schema5 { get; set; }
        public virtual DbSet<ApplicationJsons> ApplicationJsons { get; set; }
        public virtual DbSet<Schema6> Schema6 { get; set; }
        public virtual DbSet<Responses1> Responses1 { get; set; }
        public virtual DbSet<_2001> _2001 { get; set; }
        public virtual DbSet<Content2> Content2 { get; set; }
        public virtual DbSet<TextPlain1> TextPlain1 { get; set; }
        public virtual DbSet<Schema7> Schema7 { get; set; }
        public virtual DbSet<ApplicationJson2> ApplicationJson2 { get; set; }
        public virtual DbSet<Schema8> Schema8 { get; set; }
        public virtual DbSet<TextJson2> TextJson2 { get; set; }
        public virtual DbSet<Schema9> Schema9 { get; set; }
        public virtual DbSet<Components> Components { get; set; }
        public virtual DbSet<Ecivilstatus> Ecivilstatus { get; set; }
        public virtual DbSet<Includepersondto> Includepersondto { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Spouse> Spouse { get; set; }
        public virtual DbSet<Publicpensiondatadto> Publicpensiondatadto { get; set; }
        public virtual DbSet<Properties1> Properties1 { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Customer1> Customer1 { get; set; }
        public virtual DbSet<Spouse1> Spouse1 { get; set; }
        public virtual DbSet<Maritalstatus> Maritalstatus { get; set; }
        public virtual DbSet<Spouseisseniorcitizen> Spouseisseniorcitizen { get; set; }
        public virtual DbSet<Includepublicpensionextrasupplement> Includepublicpensionextrasupplement { get; set; }
        public virtual DbSet<Calculationdate> Calculationdate { get; set; }
        public virtual DbSet<Properties2> Properties2 { get; set; }
        public virtual DbSet<Publicpensiondownpaymentdto> Publicpensiondownpaymentdto { get; set; }
        public virtual DbSet<Publicpensionbase> Publicpensionbase { get; set; }
        public virtual DbSet<Publicpensionsupplement> Publicpensionsupplement { get; set; }
        public virtual DbSet<Publicpensionextrasupplement> Publicpensionextrasupplement { get; set; }
        public virtual DbSet<Averagetax> Averagetax { get; set; }
        public virtual DbSet<Publicpensionpersondto> Publicpensionpersondto { get; set; }
        public virtual DbSet<Properties3> Properties3 { get; set; }
        public virtual DbSet<Danishssn> Danishssn { get; set; }
        public virtual DbSet<Pensiondate> Pensiondate { get; set; }
        public virtual DbSet<Coronasalary> Coronasalary { get; set; }
        public virtual DbSet<Activevsoincome> Activevsoincome { get; set; }
        public virtual DbSet<Inactivevsoincome> Inactivevsoincome { get; set; }
        public virtual DbSet<Pensionincome> Pensionincome { get; set; }
        public virtual DbSet<Pensionsaving> Pensionsaving { get; set; }
        public virtual DbSet<Capitalincome> Capitalincome { get; set; }
        public virtual DbSet<Liquidity> Liquidity { get; set; }
        public virtual DbSet<Yearsabroad> Yearsabroad { get; set; }
        public virtual DbSet<Properties4> Properties4 { get; set; }
        public virtual DbSet<Customer2> Customer2 { get; set; }
        public virtual DbSet<Spouse2> Spouse2 { get; set; }
        public virtual DbSet<Requestpublicpensiondto> Requestpublicpensiondto { get; set; }
        public virtual DbSet<Properties5> Properties5 { get; set; }
        public virtual DbSet<Licensekey> Licensekey { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<Resultdto> Resultdto { get; set; }
        public virtual DbSet<Properties6> Properties6 { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Userdataasstring> Userdataasstring { get; set; }
        public virtual DbSet<Ok> Ok { get; set; }
        public virtual DbSet<Error> Error { get; set; }
        public virtual DbSet<Resultpublicpension> Resultpublicpension { get; set; }
        public virtual DbSet<Properties7> Properties7 { get; set; }
        public virtual DbSet<Base> Base { get; set; }
        public virtual DbSet<Publicpension> Publicpension { get; set; }


        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
