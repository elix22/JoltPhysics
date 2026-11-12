// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float.h"

#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstruct(void)
{
    using _mrbind_T = std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)(new std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>[num_elems]);
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>);
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)new std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>(std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_COPY(other, (std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>), std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_MOVE(other, (std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>), std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_END(other, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>))
    ));
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignFromAnother(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this, Jolt_PassBy other_pass_by, Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_COPY(other, (std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>), std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_MOVE(other, (std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>), std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>) MRBINDC_CLASSARG_END(other, std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>))
    );
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_Destroy(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this)
{
    delete ((const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)_this);
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_DestroyArray(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this)
{
    delete[] ((const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)_this);
}

const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_OffsetPtr(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *ptr, ptrdiff_t i)
{
    return (const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)(((const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)ptr) + i);
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_OffsetMutablePtr(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *ptr, ptrdiff_t i)
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)(((std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)ptr) + i);
}

bool Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_has_value(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this)
{
    return bool(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(_this)));
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_reset(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(_this)) = nullptr;
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_call(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this, unsigned int _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(_this)).operator()(
        _1,
        ((_2 ? void() : MRBINDC_THROW("Parameter `_2` can not be null.", void)), *_2),
        ((_3 ? void() : MRBINDC_THROW("Parameter `_3` can not be null.", void)), *_3),
        _4,
        _5,
        _6,
        _7,
        _8,
        _9
    );
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructStateless(void (*func)(unsigned int _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9))
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)new std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>(func ? std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>([_f = func](unsigned int _1, float &_2, float &_3, float _4, float _5, float _6, float _7, float _8, float _9) -> void
    {
        _f(
            _1,
            std::addressof(_2),
            std::addressof(_3),
            _4,
            _5,
            _6,
            _7,
            _8,
            _9
        );
    }) : nullptr);
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_Assign(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this, void (*func)(unsigned int _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    _self = [_f = func](unsigned int _1, float &_2, float &_3, float _4, float _5, float _6, float _7, float _8, float _9) -> void
    {
        _f(
            _1,
            std::addressof(_2),
            std::addressof(_3),
            _4,
            _5,
            _6,
            _7,
            _8,
            _9
        );
    };
}

namespace
{
    struct _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float
    {
        using FuncPtr = void (*)(unsigned int _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9, void *_userdata, void **_cleanup_value);
        using PostcallCbPtr = void (*)(void *_userdata, void *_cleanup_value);
        using UserdataCbPtr = void (*)(void **_this_userdata, void *_other_userdata);

        FuncPtr _func = nullptr;
        void *_userdata = nullptr;
        PostcallCbPtr _postcall_cb = nullptr;
        UserdataCbPtr _userdata_cb = nullptr;

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float(FuncPtr _func, void *_userdata, PostcallCbPtr _postcall_cb, UserdataCbPtr _userdata_cb) : _func(_func), _userdata(_userdata), _postcall_cb(_postcall_cb), _userdata_cb(_userdata_cb) {}

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float(const _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float &other) : _func(other._func), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            if (!other._userdata) return; // No data to copy.
            if (!_userdata_cb) {_userdata = other._userdata; return;} // No callback, just copy the data.
            _userdata_cb(&_userdata, other._userdata);
        }

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float(_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float &&other) noexcept : _func(other._func), _userdata(other._userdata), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            other._func = nullptr;
            other._userdata = nullptr;
            other._postcall_cb = nullptr;
            other._userdata_cb = nullptr;
        }

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float &operator=(const _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float &other)
        {
            if (_userdata_cb && _userdata_cb != other._userdata_cb) // Callback exists but incompatible, destroy the old contents first.
            {
                _userdata_cb(&_userdata, nullptr);
                _userdata = nullptr; // Don't need to zero the callbacks, we'll overwrite them anyway.
            }
            _func = other._func;
            _postcall_cb = other._postcall_cb;
            _userdata_cb = other._userdata_cb;
            if (other._userdata && _userdata_cb) // If we have data to copy and a callback, use the callback. The data must be non-null, otherwise the callback will confuse this for a copy construction.
                _userdata_cb(&_userdata, other._userdata);
            else // Otherwise shallow-copy.
                _userdata = other._userdata;
            return *this;
        }

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float &operator=(_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float &&other) noexcept
        {
            _func = other._func;
            _userdata = other._userdata;
            _postcall_cb = other._postcall_cb;
            _userdata_cb = other._userdata_cb;
            other._func = nullptr;
            other._userdata = nullptr;
            other._userdata_cb = nullptr;
            return *this;
        }

        ~_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float()
        {
            if (_userdata && _userdata_cb)
                _userdata_cb(&_userdata, nullptr);
        }

        auto operator()(unsigned int _1, float &_2, float &_3, float _4, float _5, float _6, float _7, float _8, float _9) -> void
        {
            struct _cleanup_guard_type
            {
                _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_self = nullptr;
                void *_value = nullptr;
                ~_cleanup_guard_type()
                {
                    if (_self->_postcall_cb)
                        _self->_postcall_cb(_self->_userdata, _value);
                }
            };
            _cleanup_guard_type _cleanup_guard;
            _cleanup_guard._self = this;
            
            _func(
                _1,
                std::addressof(_2),
                std::addressof(_3),
                _4,
                _5,
                _6,
                _7,
                _8,
                _9,
                _userdata,
                _postcall_cb ? &_cleanup_guard._value : nullptr
            );
        }
    };
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_ConstructEx(void (*func)(unsigned int _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *)new std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>(func ? std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)>(_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float{func, userdata, postcall_callback, userdata_callback}) : nullptr);
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float_AssignEx(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float *_this, void (*func)(unsigned int _1, float *_2, float *_3, float _4, float _5, float _6, float _7, float _8, float _9, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, float, float, float, float, float, float)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    
    _self = _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_float_float_float_float_float_float{func, userdata, postcall_callback, userdata_callback};
}

