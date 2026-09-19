#nullable disable
namespace ShopFirst; 

internal class Party
{
    private static int _nextId=1;
    public int PartyId { get; private set; }
    public string Name { get; private set; }
    public string NationalCode { get; private set; }
    public string PhoneNumber { get; private set; }
    public Party(string name, string phoneNumber, string nationalCode)
    {
        if (IsValidData(name, phoneNumber, nationalCode))
        {
            PartyId = _nextId++;
            Name = name;
            PhoneNumber = phoneNumber;
            NationalCode = nationalCode;
        }
    }
    private bool IsValidData (string name, string phoneNumber, string nationalCode)
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(phoneNumber) ||
            string.IsNullOrWhiteSpace(nationalCode) 

           )
        {
            return false;
        }
        else
            return true;
    }
}
