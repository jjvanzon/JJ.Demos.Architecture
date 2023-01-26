// DeleteRelatedEntitiesExtensions (2023-01-26):

private static IAddressRepository _addressRepository;

public static void DeleteRelatedEntities(this Customer customer)
{
    foreach (var address in customer.Addresses.ToArray())
    {
        _addressRepository.Delete(address);
    }
}
