# Array

Contiguous area of memory consisting of equal-size elements indexed by contiguous integers.

### What is special about Arrays?

- constant-time access to any element
- constant-time to add/remove at the end Big O(1)

NOTE: it has linear time to add / remove an element at arbitrary location Big O(n)

## Dynamic Arrays

They are solution to static arrays. It stores a pointer to a dynamically allocated away, and replace it with newly allocated array as needed.

### operations it can support

- Get(i) : *returns element at location i**
- Set(i,val) : *sets element i to val**
- PushBack(val) : *adds val to the end*
- Remove(i) : *removes element at location i*
- Size() : *returns length*

### implementation

- arr: dynamically allocated array
- capacity: size of the dynamically allocated array
- size : number of elements currently in the array
