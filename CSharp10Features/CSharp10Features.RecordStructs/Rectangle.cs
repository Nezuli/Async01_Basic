namespace CSharp10Features.RecordStructs
{
    internal struct Rectangle
    {
        public int Height { get; init; }
        public int Width { get; init; }
    }

    internal record PersonRecord(string FirstName);

    internal record struct PersonRecordStruct(string FirstName);

    internal record class PersonRecordClass(string FirstName);
}