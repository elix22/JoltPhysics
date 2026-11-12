// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref.h"

#include <Jolt/Physics/PhysicsStepListener.h>
#include <Jolt/Physics/Vehicle/VehicleConstraint.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <cstring>
#include <functional>
#include <memory>
#include <new>
#include <stdexcept>


Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstruct(void)
{
    using _mrbind_T = std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>;
    _mrbind_T* _mrbind_ptr = new _mrbind_T();
    _mrbind_ptr->~_mrbind_T();
    std::memset(_mrbind_ptr, 0, sizeof(_mrbind_T));
    return (Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref*)(::new(_mrbind_ptr) _mrbind_T());
}

Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DefaultConstructArray(size_t num_elems)
{
    return (Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)(new std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>[num_elems]);
}

Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructFromAnother(Jolt_PassBy other_pass_by, Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>);
    return (Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)new std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>(std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_COPY(other, (std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>), std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_MOVE(other, (std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>), std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_END(other, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>))
    ));
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignFromAnother(Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this, Jolt_PassBy other_pass_by, Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *other)
{
    MRBINDC_CLASSARG_GUARD(other, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>);
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(other, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_COPY(other, (std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>), std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_MOVE(other, (std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>), std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_DefaultArgument, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_NO_DEF_ARG(other, Jolt_PassBy_NoObject, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>) MRBINDC_CLASSARG_END(other, std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>))
    );
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_Destroy(const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this)
{
    delete ((const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)_this);
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_DestroyArray(const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this)
{
    delete[] ((const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)_this);
}

const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_OffsetPtr(const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *ptr, ptrdiff_t i)
{
    return (const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)(((const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)ptr) + i);
}

Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_OffsetMutablePtr(Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *ptr, ptrdiff_t i)
{
    return (Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)(((std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)ptr) + i);
}

bool Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_has_value(const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this)
{
    return bool(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(_this)));
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_reset(Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(_this)) = nullptr;
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_call(const Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this, JPH_VehicleConstraint *_1, const JPH_PhysicsStepListenerContext *_2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(_this)).operator()(
        ((_1 ? void() : MRBINDC_THROW("Parameter `_1` can not be null.", void)), *(JPH::VehicleConstraint *)(_1)),
        ((_2 ? void() : MRBINDC_THROW("Parameter `_2` can not be null.", void)), *(const JPH::PhysicsStepListenerContext *)(_2))
    );
}

Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructStateless(void (*func)(JPH_VehicleConstraint *_1, const JPH_PhysicsStepListenerContext *_2))
{
    return (Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)new std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>(func ? std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>([_f = func](JPH::VehicleConstraint &_1, const JPH::PhysicsStepListenerContext &_2) -> void
    {
        _f(
            (JPH_VehicleConstraint *)std::addressof(_1),
            (const JPH_PhysicsStepListenerContext *)std::addressof(_2)
        );
    }) : nullptr);
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_Assign(Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this, void (*func)(JPH_VehicleConstraint *_1, const JPH_PhysicsStepListenerContext *_2))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    _self = [_f = func](JPH::VehicleConstraint &_1, const JPH::PhysicsStepListenerContext &_2) -> void
    {
        _f(
            (JPH_VehicleConstraint *)std::addressof(_1),
            (const JPH_PhysicsStepListenerContext *)std::addressof(_2)
        );
    };
}

namespace
{
    struct _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref
    {
        using FuncPtr = void (*)(JPH_VehicleConstraint *_1, const JPH_PhysicsStepListenerContext *_2, void *_userdata, void **_cleanup_value);
        using PostcallCbPtr = void (*)(void *_userdata, void *_cleanup_value);
        using UserdataCbPtr = void (*)(void **_this_userdata, void *_other_userdata);

        FuncPtr _func = nullptr;
        void *_userdata = nullptr;
        PostcallCbPtr _postcall_cb = nullptr;
        UserdataCbPtr _userdata_cb = nullptr;

        _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref(FuncPtr _func, void *_userdata, PostcallCbPtr _postcall_cb, UserdataCbPtr _userdata_cb) : _func(_func), _userdata(_userdata), _postcall_cb(_postcall_cb), _userdata_cb(_userdata_cb) {}

        _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref(const _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref &other) : _func(other._func), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            if (!other._userdata) return; // No data to copy.
            if (!_userdata_cb) {_userdata = other._userdata; return;} // No callback, just copy the data.
            _userdata_cb(&_userdata, other._userdata);
        }

        _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref(_functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref &&other) noexcept : _func(other._func), _userdata(other._userdata), _postcall_cb(other._postcall_cb), _userdata_cb(other._userdata_cb)
        {
            other._func = nullptr;
            other._userdata = nullptr;
            other._postcall_cb = nullptr;
            other._userdata_cb = nullptr;
        }

        _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref &operator=(const _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref &other)
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

        _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref &operator=(_functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref &&other) noexcept
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

        ~_functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref()
        {
            if (_userdata && _userdata_cb)
                _userdata_cb(&_userdata, nullptr);
        }

        auto operator()(JPH::VehicleConstraint &_1, const JPH::PhysicsStepListenerContext &_2) -> void
        {
            struct _cleanup_guard_type
            {
                _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_self = nullptr;
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
                (JPH_VehicleConstraint *)std::addressof(_1),
                (const JPH_PhysicsStepListenerContext *)std::addressof(_2),
                _userdata,
                _postcall_cb ? &_cleanup_guard._value : nullptr
            );
        }
    };
}

Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_ConstructEx(void (*func)(JPH_VehicleConstraint *_1, const JPH_PhysicsStepListenerContext *_2, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    return (Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *)new std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>(func ? std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)>(_functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref{func, userdata, postcall_callback, userdata_callback}) : nullptr);
}

void Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref_AssignEx(Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref *_this, void (*func)(JPH_VehicleConstraint *_1, const JPH_PhysicsStepListenerContext *_2, void *_userdata, void **_cleanup_value), void *userdata, void (*postcall_callback)(void *_userdata, void *_cleanup_value), void (*userdata_callback)(void **_this_userdata, void *_other_userdata))
{
    auto &_self = ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(std::function<void(JPH::VehicleConstraint &, const JPH::PhysicsStepListenerContext &)> *)(_this));
    if (!func)
    {
        _self = nullptr;
        return;
    }
    
    _self = _functor_Jolt_std_function_void_from_JPH_VehicleConstraint_ref_const_JPH_PhysicsStepListenerContext_ref{func, userdata, postcall_callback, userdata_callback};
}

