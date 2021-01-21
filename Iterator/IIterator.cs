namespace Edgias.DesignPatterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();

        string Current();

        void Next();
    }
}