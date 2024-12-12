// Integer
// C# kodunu C++ a çevir
// Yes - 2, 18, 2854, -9
// No - 1.2, -5.7

#include <iostream>

int main()
{
    int age = 0;

    age = 43;

    int ageInTenYears = age + 10;

    // Two billion +/-
    // signed Int32
    // unsigned - 4 billion
    // bit - 0 or 1
    // byte - 8 bits - 00000100
    // 1, 11, 111

    std::cout << age << std::endl;
    std::cout << ageInTenYears << std::endl;

    // Don't divide ints - std::cout << (age / 2) << std::endl;

    return 0;
}

