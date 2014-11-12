EnumerableTest
==============

Test Goal : 
a custom class(RandomList) can be use in foreach.

RandomList implement IEnumerable<double> and IEnumerator<double>

RandomList generate a series of double until the generated value less then min value, so we can't predict the list length.

RandomList is not a real list, it has no memory to save generated values, so RandomList can't use [index] to get element.
