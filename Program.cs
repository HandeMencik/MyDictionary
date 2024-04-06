// See https://aka.ms/new-console-template for more information

MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
myDictionary.Add("one", 1);
myDictionary.Add("two", 2);
myDictionary.Add("three", 3);
myDictionary.Add("four", 4);

string[] keys = myDictionary.keys;
int[] values = myDictionary.values;

for (int i = 0; i < keys.Length; i++)
{
    Console.WriteLine(keys[i] +" "+ values[i]);
    
}



public class MyDictionary<Key, Value>
{
    Key[] _key;
    Value[] _value;


    public MyDictionary()
    {
        _key = new Key[0];
        _value = new Value[0];
    }

    public void Add(Key key, Value value)
    {
        Key[] tempKey = _key;
        Value[] tempValue = _value;

        _key = new Key[_key.Length + 1];
        _value = new Value[_key.Length + 1];

        for (int i = 0; i < tempKey.Length; i++)
        {
            _key[i] = tempKey[i];
        }

        for (int i = 0; i < tempValue.Length; i++)
        {
            _value[i] = tempValue[i];

        }

        _key[_key.Length - 1] = key;
        _value[_value.Length - 1] = value;

        
    }

    public Key[] keys
    {
        get { return _key; }

    }
    public Value[] values 
    { 
        get { return _value; } 
    }

}
