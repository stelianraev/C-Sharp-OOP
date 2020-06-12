namespace ValidationAttributes.Attributes
{
    public class MyRequiredAttrebute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return true;
        }
    }
}
