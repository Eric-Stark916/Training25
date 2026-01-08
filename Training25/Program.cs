// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on branch T15: Implementation of a custom generic list.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

#region class Program -----------------------------------------------------------------------------
class Program {
   #region Implementation -------------------------------------------
   /// <summary>Testing the custom 'MyList'.</summary>
   static void Main () {
      MyList<string> words = new ();
      MyList<int> nums = new ();
      // Adding items individually.
      nums.Add (10);
      nums.Add (20);
      nums.Add (23);
      nums.Add (24);
      nums.Add (25);
      PrintList (nums, "Initial List:");
      // Removing an item by value.
      nums.Remove (23);
      PrintList (nums, "Removed value 23:");
      // Removing an item in a particular index.
      nums.RemoveAt (1);
      PrintList (nums, "Removed value at index 1:");
      // Inserting at a particular index.
      nums.Insert (1, 30);
      PrintList (nums, "Inserting 30 at index 1:");
      // Checking for exceptions.
      WriteLine ("Checking Exceptions:\n");
      try {
         nums.Remove (300); // Removing a non existing number.
      } catch (Exception e) { WriteLine ($"Removing a non existing item:\nCaught exception: {e.Message}"); }
      try {
         nums.Insert (10, 50); // Inserting in a non existing index.
      } catch (Exception e) { WriteLine ($"Inserting in a non existing index:\nCaught exception: {e.Message}"); }
      nums.Clear ();
      try {
         words.Add (null!); // Inserting a null value.
      } catch (Exception e) { WriteLine ($"Inserting a null value:\nCaught exception: {e.Message}"); }

      // Helper -----------------------------------------------------
      static void PrintList<ItemType> (MyList<ItemType> list, string msg) {
         WriteLine (msg);
         for (int i = 0; i < list.Count; i++)
            WriteLine ($"Index{i}: {list[i]}");
         WriteLine ($" Count: {list.Count}\n");
      }
   }
   #endregion
}
#endregion

#region class MyList<ItemType> --------------------------------------------------------------------
class MyList<ItemType> {
   #region Constructor ----------------------------------------------
   public MyList () {
      // Initializing the list with initial size four.
      _items = new ItemType[4];
   }
   #endregion

   #region Properties -----------------------------------------------
   /// <summary>Returns the number of elements in the list.</summary>
   public int Count => _count;

   /// <summary>Returns the current capacity of the list.</summary>
   public int Capacity => _items.Length;

   /// <summary>Gets or sets the item at the specified index.<summary>
   public ItemType this[int index] {
      get {
         if (index < 0 || index >= Count) Validation (ValidationType.IndexOutOfRange, index);
         return _items[index];
      }
      set {
         if (index < 0 || index >= Count) Validation (ValidationType.IndexOutOfRange, index);
         _items[index] = value;
      }
   }
   #endregion

   #region Interface Implementation ---------------------------------
   /// <summary>Enables iteration by returning one item at a time.</summary>
   public IEnumerator<ItemType> GetEnumerator () {
      for (int i = 0; i < Count; i++) yield return _items[i];
   }
   #endregion

   #region Methods --------------------------------------------------
   /// <summary>Adds an item at the end of the list.</summary>
   public void Add (ItemType item) {
      if (item is null) Validation (ValidationType.ItemNull);
      // The capacity will be doubled if the array is full.
      if (Count == Capacity) Array.Resize (ref _items, Capacity * 2);
      _items[_count++] = item;
   }

   /// <summary>Removes all the items from the list.</summary>
   public void Clear () {
      if (Count == 0) Validation (ValidationType.InvalidOperation);
      Array.Clear (_items, 0, Count);
      _count = 0;
   }

   /// <summary>Removes specific item in the list.</summary>
   public void Remove (ItemType item) {
      var index = Array.IndexOf (_items, item);
      if (index is -1) Validation (ValidationType.InvalidOperation);
      // Shift elements to the left to overwrite the item to be removed.
      for (int i = index; i < Count - 1; i++) _items[i] = _items[i + 1];
      _count--;
      // Clear the last slot after shifting elements.
      _items[_count] = default!;
   }

   /// <summary>Removes an item in the given index.</summary>
   public void RemoveAt (int index) {
      if (index < 0 || index >= Count) Validation (ValidationType.IndexOutOfRange, index);
      for (int i = index; i < Count; i++) _items[i] = _items[i + 1];
      _count--;
      _items[_count] = default!;
   }

   /// <summary>Insert an item at the specific index.</summary>
   public void Insert (int index, ItemType item2) {
      _count++;
      if (item2 is null) Validation (ValidationType.ItemNull);
      if (index < 0 || index >= Count) Validation (ValidationType.IndexOutOfRange, index);
      if (Count == Capacity) Array.Resize (ref _items, Capacity * 2);
      // Shift elements to the right to create space for insertion.
      for (int i = Count; i > index; i--) _items[i] = _items[i - 1];
      _items[index] = item2;
   }
   #endregion

   #region Implementation -------------------------------------------
   void Validation (ValidationType type, int index = -1) {
      switch (type) {
         case ValidationType.IndexOutOfRange: throw new ArgumentOutOfRangeException (nameof (index), $"Index {index} not found.");
         case ValidationType.InvalidOperation: throw new InvalidOperationException ("Item not found.");
         case ValidationType.ItemNull: throw new ArgumentNullException ("item", "Item cannot be null.");
      }
   }
   #endregion

   #region enum ValidationType --------------------------------------
   enum ValidationType {
      IndexOutOfRange,
      InvalidOperation,
      ItemNull
   }
   #endregion

   #region Private Variables ----------------------------------------
   ItemType[] _items;
   int _count;
   #endregion
}
#endregion