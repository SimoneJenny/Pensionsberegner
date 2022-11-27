namespace Pensionsberegner
{
    public class CalculatorClasses
    {

        public class Rootobject
        {
            public string openapi { get; set; }
            public Info info { get; set; }
            public Paths paths { get; set; }
            public Components components { get; set; }
        }

        public class Info
        {
            public string title { get; set; }
            public string description { get; set; }
            public Contact contact { get; set; }
            public string version { get; set; }
        }

        public class Contact
        {
            public string name { get; set; }
            public string url { get; set; }
            public string email { get; set; }
        }

        public class Paths
        {
            public ApiLicense apiLicense { get; set; }
            public ApiPublicpension apiPublicPension { get; set; }
        }

        public class ApiLicense
        {
            public Put put { get; set; }
        }

        public class tags
        {
            public int id { get; set; }
            public string tag { get; set; }

        }

        public class Put
        {
            public tags tags { get; set; }
            public Parameter[] parameters { get; set; }
            public Responses responses { get; set; }
        }

        public class Responses
        {
            public _200 _200 { get; set; }
        }

        public class _200
        {
            public string description { get; set; }
            public Content content { get; set; }
        }

        public class Content
        {
            public TextPlain textplain { get; set; }
            public ApplicationJson applicationjson { get; set; }
            public TextJson textjson { get; set; }
        }

        public class TextPlain
        {
            public Schema schema { get; set; }
        }

        public class Schema
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson
        {
            public Schema1 schema { get; set; }
        }

        public class Schema1
        {
            public string _ref { get; set; }
        }

        public class TextJson
        {
            public Schema2 schema { get; set; }
        }

        public class Schema2
        {
            public string _ref { get; set; }
        }

        public class Parameter
        {
            public string name { get; set; }
            public string _in { get; set; }
            public Schema3 schema { get; set; }
        }

        public class Schema3
        {
            public string type { get; set; }
        }

        public class ApiPublicpension
        {
            public Put1 put { get; set; }
        }
        public class tagsforrput1
        {
            public int id { get; set; }
            public string tag { get; set; }
        }

        public class Put1
        {
            public tagsforrput1 tags { get; set; }
            public string summary { get; set; }
            public Requestbody requestBody { get; set; }
            public Responses1 responses { get; set; }
        }

        public class Requestbody
        {
            public string description { get; set; }
            public Content1 content { get; set; }
        }

        public class Content1
        {
            public ApplicationJson1 applicationjson1 { get; set; }
            public TextJson1 textjson { get; set; }
            public ApplicationJson applicationjson { get; set; }
        }

        public class ApplicationJson1
        {
            public Schema4 schema { get; set; }
        }

        public class Schema4
        {
            public string _ref { get; set; }
        }

        public class TextJson1
        {
            public Schema5 schema { get; set; }
        }

        public class Schema5
        {
            public string _ref { get; set; }
        }

        public class ApplicationJsons
        {
            public Schema6 schema { get; set; }
        }

        public class Schema6
        {
            public string _ref { get; set; }
        }

        public class Responses1
        {
            public _2001 _200 { get; set; }
        }

        public class _2001
        {
            public string description { get; set; }
            public Content2 content { get; set; }
        }

        public class Content2
        {
            public TextPlain1 textplain { get; set; }
            public ApplicationJson2 applicationjson { get; set; }
            public TextJson2 textjson { get; set; }
        }

        public class TextPlain1
        {
            public Schema7 schema { get; set; }
        }

        public class Schema7
        {
            public string _ref { get; set; }
        }

        public class ApplicationJson2
        {
            public Schema8 schema { get; set; }
        }

        public class Schema8
        {
            public string _ref { get; set; }
        }

        public class TextJson2
        {
            public Schema9 schema { get; set; }
        }

        public class Schema9
        {
            public string _ref { get; set; }
        }

        public class Components
        {
            public Schemas schemas { get; set; }
        }

        public class Schemas
        {
            public Ecivilstatus eCivilstatus { get; set; }
            public Includepersondto IncludePersonDto { get; set; }
            public Publicpensiondatadto PublicPensionDataDto { get; set; }
            public Publicpensiondownpaymentdto PublicPensionDownpaymentDto { get; set; }
            public Publicpensionpersondto PublicPensionPersonDto { get; set; }
            public Publicpensionresultdto PublicPensionResultDto { get; set; }
            public Requestpublicpensiondto RequestPublicPensionDto { get; set; }
            public Resultdto ResultDto { get; set; }
            public Resultpublicpension ResultPublicPension { get; set; }
        }

        public enum _enum
        {
            samlever = 0,
            enlig = 1
        }

        public class Ecivilstatus
        {
            public _enum _enum { get; set; }
            public string type { get; set; }
        }

        public class Includepersondto
        {
            public string type { get; set; }
            public Properties properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties
        {
            public Customer customer { get; set; }
            public Spouse spouse { get; set; }
        }

        public class Customer
        {
            public string type { get; set; }
        }

        public class Spouse
        {
            public string type { get; set; }
        }

        public class Publicpensiondatadto
        {
            public string type { get; set; }
            public Properties1 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties1
        {
            public Person person { get; set; }
            public Customer1 customer { get; set; }
            public Spouse1 spouse { get; set; }
            public Maritalstatus maritalStatus { get; set; }
            public Spouseisseniorcitizen spouseIsSeniorCitizen { get; set; }
            public Calculationdate calculationDate { get; set; }
            public Includepublicpensionextrasupplement includePublicPensionExtraSupplement { get; set; }
        }

        public class Person
        {
            public string _ref { get; set; }
        }

        public class Customer1
        {
            public string _ref { get; set; }
        }

        public class Spouse1
        {
            public string _ref { get; set; }
        }

        public class Maritalstatus
        {
            public string _ref { get; set; }
        }

        public class Spouseisseniorcitizen
        {
            public string type { get; set; }
        }

        public class Calculationdate
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Includepublicpensionextrasupplement
        {
            public string type { get; set; }
        }

        public class Publicpensiondownpaymentdto
        {
            public string type { get; set; }
            public Properties2 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties2
        {
            public Publicpensionbase publicPensionBase { get; set; }
            public Publicpensionsupplement publicPensionSupplement { get; set; }
            public Publicpensionextrasupplement publicPensionExtraSupplement { get; set; }
            public Averagetax averageTax { get; set; }
        }

        public class Publicpensionbase
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Publicpensionsupplement
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Publicpensionextrasupplement
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Averagetax
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Publicpensionpersondto
        {
            public string type { get; set; }
            public Properties3 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties3
        {
            public Danishssn danishSSN { get; set; }
            public Pensiondate pensionDate { get; set; }
            public Salary salary { get; set; }
            public Coronasalary coronaSalary { get; set; }
            public Activevsoincome activeVSOIncome { get; set; }
            public Inactivevsoincome inactiveVSOIncome { get; set; }
            public Pensionincome pensionIncome { get; set; }
            public Pensionsaving pensionSaving { get; set; }
            public Capitalincome capitalIncome { get; set; }
            public Liquidity liquidity { get; set; }
            public Nationalchurchmember nationalChurchMember { get; set; }
            public Yearsabroad yearsAbroad { get; set; }
        }

        public class Danishssn
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Pensiondate
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Salary
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Coronasalary
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Activevsoincome
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Inactivevsoincome
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Pensionincome
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Pensionsaving
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Capitalincome
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Liquidity
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Nationalchurchmember
        {
            public string type { get; set; }
        }

        public class Yearsabroad
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Publicpensionresultdto
        {
            public string type { get; set; }
            public Properties4 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties4
        {
            public Customer2 customer { get; set; }
            public Spouse2 spouse { get; set; }
        }

        public class Customer2
        {
            public string _ref { get; set; }
        }

        public class Spouse2
        {
            public string _ref { get; set; }
        }

        public class Requestpublicpensiondto
        {
            public string type { get; set; }
            public Properties5 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties5
        {
            public Licensekey licenseKey { get; set; }
            public Data data { get; set; }
        }

        public class Licensekey
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Data
        {
            public string _ref { get; set; }
        }

        public class Resultdto
        {
            public string type { get; set; }
            public Properties6 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties6
        {
            public Log log { get; set; }
            public Userdataasstring userdataAsString { get; set; }
            public Ok ok { get; set; }
            public Error error { get; set; }
        }

        public class Log
        {
            public string type { get; set; }
            public Items items { get; set; }
            public bool nullable { get; set; }
        }

        public class Items
        {
            public string type { get; set; }
        }

        public class Userdataasstring
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Ok
        {
            public string type { get; set; }
        }

        public class Error
        {
            public string type { get; set; }
            public bool nullable { get; set; }
        }

        public class Resultpublicpension
        {
            public string type { get; set; }
            public Properties7 properties { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Properties7
        {
            public Base _base { get; set; }
            public Publicpension publicPension { get; set; }
        }

        public class Base
        {
            public string _ref { get; set; }
        }

        public class Publicpension
        {
            public string _ref { get; set; }
        }


    }
}
