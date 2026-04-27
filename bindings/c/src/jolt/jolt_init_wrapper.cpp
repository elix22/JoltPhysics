// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/jolt_init_wrapper.h"

#include <__mrbind_c_details.h>
#include <jolt_init_wrapper.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


JoltHelpers *JoltHelpers_DefaultConstruct(void)
{
    return (JoltHelpers *)new JoltHelpers(JoltHelpers());
}

JoltHelpers *JoltHelpers_DefaultConstructArray(size_t num_elems)
{
    return (JoltHelpers *)(new JoltHelpers[num_elems]{});
}

const JoltHelpers *JoltHelpers_OffsetPtr(const JoltHelpers *ptr, ptrdiff_t i)
{
    return (const JoltHelpers *)(((const JoltHelpers *)ptr) + i);
}

JoltHelpers *JoltHelpers_OffsetMutablePtr(JoltHelpers *ptr, ptrdiff_t i)
{
    return (JoltHelpers *)(((JoltHelpers *)ptr) + i);
}

JoltHelpers *JoltHelpers_ConstructFromAnother(const JoltHelpers *_other)
{
    return (JoltHelpers *)new JoltHelpers(JoltHelpers(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltHelpers(*(JoltHelpers *)_other))
    ));
}

void JoltHelpers_Destroy(const JoltHelpers *_this)
{
    delete ((const JoltHelpers *)_this);
}

void JoltHelpers_DestroyArray(const JoltHelpers *_this)
{
    delete[] ((const JoltHelpers *)_this);
}

JoltHelpers *JoltHelpers_AssignFromAnother(JoltHelpers *_this, const JoltHelpers *_other)
{
    return (JoltHelpers *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JoltHelpers *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JoltHelpers(*(JoltHelpers *)_other))
    ));
}

void JoltHelpers_Init(void)
{
    JoltHelpers::Init();
}

void JoltHelpers_Shutdown(void)
{
    JoltHelpers::Shutdown();
}

