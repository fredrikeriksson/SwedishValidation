namespace SwedishValidation
{
    public class ValidationRegEx
    {
        public const string PhoneNumber = @"^(([+]\d{2}[ ][1-9]\d{0,2}[ ])|([0]\d{1,3}[-]))((\d{2}([ ]\d{2}){2})|(\d{3}([ ]\d{3})*([ ]\d{2})+))$";
        public const string SocialSecurityNumber = @"^[0-9]{6}[\-|\+][0-9]{4}$";
    }
}