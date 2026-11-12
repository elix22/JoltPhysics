// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "std_function_JPH_Vec3_from_JPH_Vec3.h"

#include <Jolt/Math/Vec3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstruct(void)
{
    using _mrbind_T = std::function<JPH::Vec3(JPH::Vec3)>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_std_function_JPH_Vec3_from_JPH_Vec3*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *)(new std::function<JPH::Vec3(JPH::Vec3)>[num_elems]);
}

Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<JPH::Vec3(JPH::Vec3)>);
    return (Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *)new std::function<JPH::Vec3(JPH::Vec3)>(std::function<JPH::Vec3(JPH::Vec3)>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_COPY(other, (std::function<JPH::Vec3(JPH::Vec3)>), std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_MOVE(other, (std::function<JPH::Vec3(JPH::Vec3)>), std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_END(other, std::function<JPH::Vec3(JPH::Vec3)>))
    ));
}

void Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignFromAnother(Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this, Jolt_PassBy other_pass_by, Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<JPH::Vec3(JPH::Vec3)>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<JPH::Vec3(JPH::Vec3)> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_COPY(other, (std::function<JPH::Vec3(JPH::Vec3)>), std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_MOVE(other, (std::function<JPH::Vec3(JPH::Vec3)>), std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<JPH::Vec3(JPH::Vec3)>) MRBINDC_CLASSARG_END(other, std::function<JPH::Vec3(JPH::Vec3)>))
    );
}

void Jolt_std_function_JPH_Vec3_from_JPH_Vec3_Destroy(const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this)
{
    delete ((const std::function<JPH::Vec3(JPH::Vec3)> *)_this);
}

void Jolt_std_function_JPH_Vec3_from_JPH_Vec3_DestroyArray(const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this)
{
    delete[] ((const std::function<JPH::Vec3(JPH::Vec3)> *)_this);
}

const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_OffsetPtr(const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *ptr, ptrdiff_t i)
{
    return (const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *)(((const std::function<JPH::Vec3(JPH::Vec3)> *)ptr) + i);
}

Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_OffsetMutablePtr(Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *ptr, ptrdiff_t i)
{
    return (Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *)(((std::function<JPH::Vec3(JPH::Vec3)> *)ptr) + i);
}

bool Jolt_std_function_JPH_Vec3_from_JPH_Vec3_has_value(const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this)
{
    return bool(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<JPH::Vec3(JPH::Vec3)> *)(_this)));
}

void Jolt_std_function_JPH_Vec3_from_JPH_Vec3_reset(Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<JPH::Vec3(JPH::Vec3)> *)(_this)) = nullptr;
}

JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_call(const Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this, const JPH_Vec3 *_1)
{
    return (JPH_Vec3 *)new JPH::Vec3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<JPH::Vec3(JPH::Vec3)> *)(_this)).operator()(
        ((_1 ? void() : MRBINDC_THROW("Parameter `_1` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)_1))
    ));
}

Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructStateless(const JPH_Vec3 *(*func)(JPH_Vec3 *_1))
{
    return (Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *)new std::function<JPH::Vec3(JPH::Vec3)>(func ? std::function<JPH::Vec3(JPH::Vec3)>([_f = func](JPH::Vec3 _1) -> JPH::Vec3
    {
        decltype(auto) _return = _f(
            (JPH_Vec3 *)std::addressof(mrbindc_details::unmove(_1))
        );
        return ((_return ? void() : MRBINDC_THROW("Parameter `_return` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)_return));
    }) : nullptr);
}

void Jolt_std_function_JPH_Vec3_from_JPH_Vec3_Assign(Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this, const JPH_Vec3 *(*func)(JPH_Vec3 *_1))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<JPH::Vec3(JPH::Vec3)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    _self = [_f = func](JPH::Vec3 _1) -> JPH::Vec3
    {
        decltype(auto) _return = _f(
            (JPH_Vec3 *)std::addressof(mrbindc_details::unmove(_1))
        );
        return ((_return ? void() : MRBINDC_THROW("Parameter `_return` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)_return));
    };
}

namespace
{
    struct _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3
    {
        using FuncPtr = const JPH_Vec3 *(*)(JPH_Vec3 *_1, void *_userdata, void **_cleanup_value);
        using PostcallCbPtr = void (*)(void *_userdata, void *_cleanup_value);
        using UserdataCbPtr = void (*)(void **_this_userdata, void *_other_userdata);

        FuncPtr _func = nullptr;
        void *_userdata = nullptr;
        PostcallCbPtr _postcall_cb = nullptr;
        UserdataCbPtr _userdata_cb = nullptr;

        _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3(FuncPtr _func, void *_userdata, PostcallCbPtr _postcall_cb, UserdataCbPtr _userdata_cb) : _func(_func), _userdata(_userdata), _postcall_cb(_postcall_cb), _userdata_cb(_userdata_cb) {}

        _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3(const _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 &other) : _func(other._func), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            if (!other._userdata) return; // No data to copy.
            if (!_userdata_cb) {_userdata = other._userdata; return;} // No callback, just copy the data.
            _userdata_cb(&_userdata, other._userdata);
        }

        _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3(_functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 &&other) noexcept : _func(other._func), _userdata(other._userdata), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            other._func = nullptr;
            other._userdata = nullptr;
            other._postcall_cb = nullptr;
            other._userdata_cb = nullptr;
        }

        _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 &operator=(const _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 &other)
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

        _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 &operator=(_functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 &&other) noexcept
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

        ~_functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3()
        {
            if (_userdata && _userdata_cb)
                _userdata_cb(&_userdata, nullptr);
        }

        auto operator()(JPH::Vec3 _1) -> JPH::Vec3
        {
            struct _cleanup_guard_type
            {
                _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_self = nullptr;
                void *_value = nullptr;
                ~_cleanup_guard_type()
                {
                    if (_self->_postcall_cb)
                        _self->_postcall_cb(_self->_userdata, _value);
                }
            };
            _cleanup_guard_type _cleanup_guard;
            _cleanup_guard._self = this;
            
            decltype(auto) _return = _func(
                (JPH_Vec3 *)std::addressof(mrbindc_details::unmove(_1)),
                _userdata,
                _postcall_cb ? &_cleanup_guard._value : nullptr
            );
            return ((_return ? void() : MRBINDC_THROW("Parameter `_return` can not be null.", void)), JPH::Vec3(*(JPH::Vec3 *)_return));
        }
    };
}

Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *Jolt_std_function_JPH_Vec3_from_JPH_Vec3_ConstructEx(const JPH_Vec3 *(*func)(JPH_Vec3 *_1, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    return (Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *)new std::function<JPH::Vec3(JPH::Vec3)>(func ? std::function<JPH::Vec3(JPH::Vec3)>(_functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3{func, userdata, postcall_callback, userdata_callback}) : nullptr);
}

void Jolt_std_function_JPH_Vec3_from_JPH_Vec3_AssignEx(Jolt_std_function_JPH_Vec3_from_JPH_Vec3 *_this, const JPH_Vec3 *(*func)(JPH_Vec3 *_1, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<JPH::Vec3(JPH::Vec3)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    
    _self = _functor_Jolt_std_function_JPH_Vec3_from_JPH_Vec3{func, userdata, postcall_callback, userdata_callback};
}

