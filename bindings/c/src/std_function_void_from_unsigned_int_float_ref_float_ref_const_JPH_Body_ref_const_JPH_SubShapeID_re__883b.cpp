// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_re__883b.h"

#include <Jolt/Physics/Body/Body.h>
#include <Jolt/Physics/Collision/Shape/SubShapeID.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_DefaultConstruct(void)
{
    using _mrbind_T = std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)(new std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>[num_elems]);
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>);
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)new std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>(std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_COPY(other, (std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>), std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_MOVE(other, (std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>), std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_END(other, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>))
    ));
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_AssignFromAnother(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this, Jolt_PassBy other_pass_by, Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_COPY(other, (std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>), std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_MOVE(other, (std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>), std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>) MRBINDC_CLASSARG_END(other, std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>))
    );
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_Destroy(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this)
{
    delete ((const std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)_this);
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_DestroyArray(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this)
{
    delete[] ((const std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)_this);
}

const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_OffsetPtr(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *ptr, ptrdiff_t i)
{
    return (const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)(((const std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)ptr) + i);
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_OffsetMutablePtr(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *ptr, ptrdiff_t i)
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)(((std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)ptr) + i);
}

bool Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_has_value(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this)
{
    return bool(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(_this)));
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_reset(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(_this)) = nullptr;
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_call(const Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this, unsigned int _1, float *_2, float *_3, const JPH_Body *_4, const JPH_SubShapeID *_5)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(_this)).operator()(
        _1,
        ((_2 ? void() : MRBINDC_THROW("Parameter `_2` can not be null.", void)), *_2),
        ((_3 ? void() : MRBINDC_THROW("Parameter `_3` can not be null.", void)), *_3),
        ((_4 ? void() : MRBINDC_THROW("Parameter `_4` can not be null.", void)), *(const JPH::Body *)(_4)),
        ((_5 ? void() : MRBINDC_THROW("Parameter `_5` can not be null.", void)), *(const JPH::SubShapeID *)(_5))
    );
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_ConstructStateless(void (*func)(unsigned int _1, float *_2, float *_3, const JPH_Body *_4, const JPH_SubShapeID *_5))
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)new std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>(func ? std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>([_f = func](unsigned int _1, float &_2, float &_3, const JPH::Body &_4, const JPH::SubShapeID &_5) -> void
    {
        _f(
            _1,
            std::addressof(_2),
            std::addressof(_3),
            (const JPH_Body *)std::addressof(_4),
            (const JPH_SubShapeID *)std::addressof(_5)
        );
    }) : nullptr);
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_Assign(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this, void (*func)(unsigned int _1, float *_2, float *_3, const JPH_Body *_4, const JPH_SubShapeID *_5))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    _self = [_f = func](unsigned int _1, float &_2, float &_3, const JPH::Body &_4, const JPH::SubShapeID &_5) -> void
    {
        _f(
            _1,
            std::addressof(_2),
            std::addressof(_3),
            (const JPH_Body *)std::addressof(_4),
            (const JPH_SubShapeID *)std::addressof(_5)
        );
    };
}

namespace
{
    struct _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref
    {
        using FuncPtr = void (*)(unsigned int _1, float *_2, float *_3, const JPH_Body *_4, const JPH_SubShapeID *_5, void *_userdata, void **_cleanup_value);
        using PostcallCbPtr = void (*)(void *_userdata, void *_cleanup_value);
        using UserdataCbPtr = void (*)(void **_this_userdata, void *_other_userdata);

        FuncPtr _func = nullptr;
        void *_userdata = nullptr;
        PostcallCbPtr _postcall_cb = nullptr;
        UserdataCbPtr _userdata_cb = nullptr;

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref(FuncPtr _func, void *_userdata, PostcallCbPtr _postcall_cb, UserdataCbPtr _userdata_cb) : _func(_func), _userdata(_userdata), _postcall_cb(_postcall_cb), _userdata_cb(_userdata_cb) {}

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref(const _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref &other) : _func(other._func), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            if (!other._userdata) return; // No data to copy.
            if (!_userdata_cb) {_userdata = other._userdata; return;} // No callback, just copy the data.
            _userdata_cb(&_userdata, other._userdata);
        }

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref(_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref &&other) noexcept : _func(other._func), _userdata(other._userdata), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            other._func = nullptr;
            other._userdata = nullptr;
            other._postcall_cb = nullptr;
            other._userdata_cb = nullptr;
        }

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref &operator=(const _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref &other)
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

        _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref &operator=(_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref &&other) noexcept
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

        ~_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref()
        {
            if (_userdata && _userdata_cb)
                _userdata_cb(&_userdata, nullptr);
        }

        auto operator()(unsigned int _1, float &_2, float &_3, const JPH::Body &_4, const JPH::SubShapeID &_5) -> void
        {
            struct _cleanup_guard_type
            {
                _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_self = nullptr;
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
                (const JPH_Body *)std::addressof(_4),
                (const JPH_SubShapeID *)std::addressof(_5),
                _userdata,
                _postcall_cb ? &_cleanup_guard._value : nullptr
            );
        }
    };
}

Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_ConstructEx(void (*func)(unsigned int _1, float *_2, float *_3, const JPH_Body *_4, const JPH_SubShapeID *_5, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    return (Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *)new std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>(func ? std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)>(_functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref{func, userdata, postcall_callback, userdata_callback}) : nullptr);
}

void Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref_AssignEx(Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref *_this, void (*func)(unsigned int _1, float *_2, float *_3, const JPH_Body *_4, const JPH_SubShapeID *_5, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(unsigned int, float &, float &, const JPH::Body &, const JPH::SubShapeID &)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    
    _self = _functor_Jolt_std_function_void_from_unsigned_int_float_ref_float_ref_const_JPH_Body_ref_const_JPH_SubShapeID_ref{func, userdata, postcall_callback, userdata_callback};
}

