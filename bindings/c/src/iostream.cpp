// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "iostream.h"

#include <iostream>
#include <memory>


Jolt_std_ostream *Jolt_GetStdCout(void)
{
    return (Jolt_std_ostream *)std::addressof(std::cout);
}

Jolt_std_ostream *Jolt_GetStdCerr(void)
{
    return (Jolt_std_ostream *)std::addressof(std::cerr);
}

Jolt_std_ostream *Jolt_GetStdClog(void)
{
    return (Jolt_std_ostream *)std::addressof(std::clog);
}

Jolt_std_istream *Jolt_GetStdCin(void)
{
    return (Jolt_std_istream *)std::addressof(std::cin);
}

