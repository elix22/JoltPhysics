// machine generated, do not edit
#define JOLT_BUILD_LIBRARY
#include "jolt/Jolt/Physics/SoftBody/SoftBodySharedSettings.h"

#include <Jolt/Core/Reference.h>
#include <Jolt/Math/Float3.h>
#include <Jolt/Math/Mat44.h>
#include <Jolt/Math/Quat.h>
#include <Jolt/Physics/SoftBody/SoftBodySharedSettings.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>
#include <type_traits>


JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings *)new JPH::SoftBodySharedSettings(JPH::SoftBodySharedSettings());
}

JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings *)(new JPH::SoftBodySharedSettings[num_elems]{});
}

const JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_OffsetPtr(const JPH_SoftBodySharedSettings *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings *)(((const JPH::SoftBodySharedSettings *)ptr) + i);
}

JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_OffsetMutablePtr(JPH_SoftBodySharedSettings *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings *)(((JPH::SoftBodySharedSettings *)ptr) + i);
}

const JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_UpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(const JPH_SoftBodySharedSettings *object)
{
    return (const JPH_RefTarget_JPH_SoftBodySharedSettings *)(static_cast<const JPH::RefTarget<JPH::SoftBodySharedSettings> *>(
        ((const JPH::SoftBodySharedSettings *)object)
    ));
}

JPH_RefTarget_JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_MutableUpcastTo_JPH_RefTarget_JPH_SoftBodySharedSettings(JPH_SoftBodySharedSettings *object)
{
    return (JPH_RefTarget_JPH_SoftBodySharedSettings *)(static_cast<JPH::RefTarget<JPH::SoftBodySharedSettings> *>(
        ((JPH::SoftBodySharedSettings *)object)
    ));
}

const JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_StaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(const JPH_RefTarget_JPH_SoftBodySharedSettings *object)
{
    return (const JPH_SoftBodySharedSettings *)(static_cast<const JPH::SoftBodySharedSettings *>(
        ((const JPH::RefTarget<JPH::SoftBodySharedSettings> *)object)
    ));
}

JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_MutableStaticDowncastFrom_JPH_RefTarget_JPH_SoftBodySharedSettings(JPH_RefTarget_JPH_SoftBodySharedSettings *object)
{
    return (JPH_SoftBodySharedSettings *)(static_cast<JPH::SoftBodySharedSettings *>(
        ((JPH::RefTarget<JPH::SoftBodySharedSettings> *)object)
    ));
}

JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodySharedSettings);
    return (JPH_SoftBodySharedSettings *)new JPH::SoftBodySharedSettings(JPH::SoftBodySharedSettings(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodySharedSettings), JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SoftBodySharedSettings), JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_END(_other, JPH::SoftBodySharedSettings))
    ));
}

void JPH_SoftBodySharedSettings_Destroy(const JPH_SoftBodySharedSettings *_this)
{
    delete ((const JPH::SoftBodySharedSettings *)_this);
}

void JPH_SoftBodySharedSettings_DestroyArray(const JPH_SoftBodySharedSettings *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings *)_this);
}

JPH_SoftBodySharedSettings *JPH_SoftBodySharedSettings_AssignFromAnother(JPH_SoftBodySharedSettings *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodySharedSettings);
    return (JPH_SoftBodySharedSettings *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodySharedSettings), JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_MOVE(_other, (JPH::SoftBodySharedSettings), JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodySharedSettings) MRBINDC_CLASSARG_END(_other, JPH::SoftBodySharedSettings))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SoftBodySharedSettings_CreateConstraints(JPH_SoftBodySharedSettings *_this, const JPH_SoftBodySharedSettings_VertexAttributes *inVertexAttributes, unsigned int inVertexAttributesLength, const JPH_SoftBodySharedSettings_EBendType *inBendType, const float *inAngleTolerance)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CreateConstraints(
        ((const JPH::SoftBodySharedSettings::VertexAttributes *)inVertexAttributes),
        inVertexAttributesLength,
        (inBendType ? (JPH::SoftBodySharedSettings::EBendType)(*inBendType) : static_cast<JPH::SoftBodySharedSettings::EBendType>(JPH::SoftBodySharedSettings::EBendType::Distance)),
        (inAngleTolerance ? *inAngleTolerance : static_cast<float>(DegreesToRadians(8.F)))
    );
}

void JPH_SoftBodySharedSettings_CalculateEdgeLengths(JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CalculateEdgeLengths();
}

void JPH_SoftBodySharedSettings_CalculateRodProperties(JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CalculateRodProperties();
}

void JPH_SoftBodySharedSettings_CalculateLRALengths(JPH_SoftBodySharedSettings *_this, const float *inMaxDistanceMultiplier)
{
    using namespace JPH;
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CalculateLRALengths(
        (inMaxDistanceMultiplier ? *inMaxDistanceMultiplier : static_cast<float>(1.F))
    );
}

void JPH_SoftBodySharedSettings_CalculateBendConstraintConstants(JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CalculateBendConstraintConstants();
}

void JPH_SoftBodySharedSettings_CalculateVolumeConstraintVolumes(JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CalculateVolumeConstraintVolumes();
}

void JPH_SoftBodySharedSettings_CalculateSkinnedConstraintNormals(JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).CalculateSkinnedConstraintNormals();
}

void JPH_SoftBodySharedSettings_Optimize_1(JPH_SoftBodySharedSettings *_this, JPH_SoftBodySharedSettings_OptimizationResults *outResults)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).Optimize(
        ((outResults ? void() : MRBINDC_THROW("Parameter `outResults` can not be null.", void)), *(JPH::SoftBodySharedSettings::OptimizationResults *)(outResults))
    );
}

void JPH_SoftBodySharedSettings_Optimize_0(JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).Optimize();
}

void JPH_SoftBodySharedSettings_AddFace(JPH_SoftBodySharedSettings *_this, const JPH_SoftBodySharedSettings_Face *inFace)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings *)(_this)).AddFace(
        ((inFace ? void() : MRBINDC_THROW("Parameter `inFace` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Face *)(inFace))
    );
}

void JPH_SoftBodySharedSettings_SetEmbedded(const JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings *)(_this)).SetEmbedded();
}

unsigned int JPH_SoftBodySharedSettings_GetRefCount(const JPH_SoftBodySharedSettings *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings *)(_this)).GetRefCount();
}

void JPH_SoftBodySharedSettings_AddRef(const JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings *)(_this)).AddRef();
}

void JPH_SoftBodySharedSettings_Release(const JPH_SoftBodySharedSettings *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings *)(_this)).Release();
}

int JPH_SoftBodySharedSettings_sInternalGetRefCountOffset(void)
{
    return JPH::SoftBodySharedSettings::sInternalGetRefCountOffset();
}

const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mCompliance(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mCompliance);
}

void JPH_SoftBodySharedSettings_VertexAttributes_Set_mCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mCompliance = value;
}

float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mCompliance);
}

const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mShearCompliance(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mShearCompliance);
}

void JPH_SoftBodySharedSettings_VertexAttributes_Set_mShearCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mShearCompliance = value;
}

float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mShearCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mShearCompliance);
}

const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mBendCompliance(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mBendCompliance);
}

void JPH_SoftBodySharedSettings_VertexAttributes_Set_mBendCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mBendCompliance = value;
}

float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mBendCompliance(JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mBendCompliance);
}

const JPH_SoftBodySharedSettings_ELRAType *JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAType(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return (const JPH_SoftBodySharedSettings_ELRAType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mLRAType);
}

void JPH_SoftBodySharedSettings_VertexAttributes_Set_mLRAType(JPH_SoftBodySharedSettings_VertexAttributes *_this, JPH_SoftBodySharedSettings_ELRAType value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mLRAType = ((JPH::SoftBodySharedSettings::ELRAType)value);
}

JPH_SoftBodySharedSettings_ELRAType *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAType(JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return (JPH_SoftBodySharedSettings_ELRAType *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mLRAType);
}

const float *JPH_SoftBodySharedSettings_VertexAttributes_Get_mLRAMaxDistanceMultiplier(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mLRAMaxDistanceMultiplier);
}

void JPH_SoftBodySharedSettings_VertexAttributes_Set_mLRAMaxDistanceMultiplier(JPH_SoftBodySharedSettings_VertexAttributes *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mLRAMaxDistanceMultiplier = value;
}

float *JPH_SoftBodySharedSettings_VertexAttributes_GetMutable_mLRAMaxDistanceMultiplier(JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).mLRAMaxDistanceMultiplier);
}

JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_VertexAttributes *)new JPH::SoftBodySharedSettings::VertexAttributes(JPH::SoftBodySharedSettings::VertexAttributes());
}

JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_VertexAttributes *)(new JPH::SoftBodySharedSettings::VertexAttributes[num_elems]{});
}

const JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_OffsetPtr(const JPH_SoftBodySharedSettings_VertexAttributes *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_VertexAttributes *)(((const JPH::SoftBodySharedSettings::VertexAttributes *)ptr) + i);
}

JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_OffsetMutablePtr(JPH_SoftBodySharedSettings_VertexAttributes *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_VertexAttributes *)(((JPH::SoftBodySharedSettings::VertexAttributes *)ptr) + i);
}

JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_ConstructFromAnother(const JPH_SoftBodySharedSettings_VertexAttributes *_other)
{
    return (JPH_SoftBodySharedSettings_VertexAttributes *)new JPH::SoftBodySharedSettings::VertexAttributes(JPH::SoftBodySharedSettings::VertexAttributes(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::VertexAttributes(*(JPH::SoftBodySharedSettings::VertexAttributes *)_other))
    ));
}

JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_Construct(float inCompliance, float inShearCompliance, float inBendCompliance, const JPH_SoftBodySharedSettings_ELRAType *inLRAType, const float *inLRAMaxDistanceMultiplier)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_VertexAttributes *)new JPH::SoftBodySharedSettings::VertexAttributes(JPH::SoftBodySharedSettings::VertexAttributes(
        inCompliance,
        inShearCompliance,
        inBendCompliance,
        (inLRAType ? (JPH::SoftBodySharedSettings::ELRAType)(*inLRAType) : static_cast<JPH::SoftBodySharedSettings::ELRAType>(JPH::SoftBodySharedSettings::ELRAType::None)),
        (inLRAMaxDistanceMultiplier ? *inLRAMaxDistanceMultiplier : static_cast<float>(1.F))
    ));
}

void JPH_SoftBodySharedSettings_VertexAttributes_Destroy(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    delete ((const JPH::SoftBodySharedSettings::VertexAttributes *)_this);
}

void JPH_SoftBodySharedSettings_VertexAttributes_DestroyArray(const JPH_SoftBodySharedSettings_VertexAttributes *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::VertexAttributes *)_this);
}

JPH_SoftBodySharedSettings_VertexAttributes *JPH_SoftBodySharedSettings_VertexAttributes_AssignFromAnother(JPH_SoftBodySharedSettings_VertexAttributes *_this, const JPH_SoftBodySharedSettings_VertexAttributes *_other)
{
    return (JPH_SoftBodySharedSettings_VertexAttributes *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::VertexAttributes *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::VertexAttributes(*(JPH::SoftBodySharedSettings::VertexAttributes *)_other))
    ));
}

JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_OptimizationResults *)new JPH::SoftBodySharedSettings::OptimizationResults(JPH::SoftBodySharedSettings::OptimizationResults());
}

JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_OptimizationResults *)(new JPH::SoftBodySharedSettings::OptimizationResults[num_elems]{});
}

JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_ConstructFromAnother(Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings_OptimizationResults *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodySharedSettings::OptimizationResults);
    return (JPH_SoftBodySharedSettings_OptimizationResults *)new JPH::SoftBodySharedSettings::OptimizationResults(JPH::SoftBodySharedSettings::OptimizationResults(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodySharedSettings::OptimizationResults), JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_MOVE(_other, (JPH::SoftBodySharedSettings::OptimizationResults), JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_END(_other, JPH::SoftBodySharedSettings::OptimizationResults))
    ));
}

void JPH_SoftBodySharedSettings_OptimizationResults_Destroy(const JPH_SoftBodySharedSettings_OptimizationResults *_this)
{
    delete ((const JPH::SoftBodySharedSettings::OptimizationResults *)_this);
}

void JPH_SoftBodySharedSettings_OptimizationResults_DestroyArray(const JPH_SoftBodySharedSettings_OptimizationResults *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::OptimizationResults *)_this);
}

JPH_SoftBodySharedSettings_OptimizationResults *JPH_SoftBodySharedSettings_OptimizationResults_AssignFromAnother(JPH_SoftBodySharedSettings_OptimizationResults *_this, Jolt_PassBy _other_pass_by, JPH_SoftBodySharedSettings_OptimizationResults *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, JPH::SoftBodySharedSettings::OptimizationResults);
    return (JPH_SoftBodySharedSettings_OptimizationResults *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::OptimizationResults *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_COPY(_other, (JPH::SoftBodySharedSettings::OptimizationResults), JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_MOVE(_other, (JPH::SoftBodySharedSettings::OptimizationResults), JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_DefaultArgument, JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Jolt_PassBy_NoObject, JPH::SoftBodySharedSettings::OptimizationResults) MRBINDC_CLASSARG_END(_other, JPH::SoftBodySharedSettings::OptimizationResults))
    ));
}

const JPH_Float3 *JPH_SoftBodySharedSettings_Vertex_Get_mPosition(const JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (const JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Vertex *)(_this)).mPosition);
}

JPH_Float3 *JPH_SoftBodySharedSettings_Vertex_GetMutable_mPosition(JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Vertex *)(_this)).mPosition);
}

const JPH_Float3 *JPH_SoftBodySharedSettings_Vertex_Get_mVelocity(const JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (const JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Vertex *)(_this)).mVelocity);
}

JPH_Float3 *JPH_SoftBodySharedSettings_Vertex_GetMutable_mVelocity(JPH_SoftBodySharedSettings_Vertex *_this)
{
    return (JPH_Float3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Vertex *)(_this)).mVelocity);
}

const float *JPH_SoftBodySharedSettings_Vertex_Get_mInvMass(const JPH_SoftBodySharedSettings_Vertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Vertex *)(_this)).mInvMass);
}

void JPH_SoftBodySharedSettings_Vertex_Set_mInvMass(JPH_SoftBodySharedSettings_Vertex *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Vertex *)(_this)).mInvMass = value;
}

float *JPH_SoftBodySharedSettings_Vertex_GetMutable_mInvMass(JPH_SoftBodySharedSettings_Vertex *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Vertex *)(_this)).mInvMass);
}

JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_Vertex *)new JPH::SoftBodySharedSettings::Vertex(JPH::SoftBodySharedSettings::Vertex());
}

JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_Vertex *)(new JPH::SoftBodySharedSettings::Vertex[num_elems]{});
}

const JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_OffsetPtr(const JPH_SoftBodySharedSettings_Vertex *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_Vertex *)(((const JPH::SoftBodySharedSettings::Vertex *)ptr) + i);
}

JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_OffsetMutablePtr(JPH_SoftBodySharedSettings_Vertex *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_Vertex *)(((JPH::SoftBodySharedSettings::Vertex *)ptr) + i);
}

JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_ConstructFromAnother(const JPH_SoftBodySharedSettings_Vertex *_other)
{
    return (JPH_SoftBodySharedSettings_Vertex *)new JPH::SoftBodySharedSettings::Vertex(JPH::SoftBodySharedSettings::Vertex(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Vertex(*(JPH::SoftBodySharedSettings::Vertex *)_other))
    ));
}

JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_Construct(const JPH_Float3 *inPosition, const JPH_Float3 *inVelocity, const float *inInvMass)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_Vertex *)new JPH::SoftBodySharedSettings::Vertex(JPH::SoftBodySharedSettings::Vertex(
        ((inPosition ? void() : MRBINDC_THROW("Parameter `inPosition` can not be null.", void)), *(const JPH::Float3 *)(inPosition)),
        (inVelocity ? *(const JPH::Float3 *)(inVelocity) : static_cast<const JPH::Float3 &>(JPH::Float3(0, 0, 0))),
        (inInvMass ? *inInvMass : static_cast<float>(1.F))
    ));
}

void JPH_SoftBodySharedSettings_Vertex_Destroy(const JPH_SoftBodySharedSettings_Vertex *_this)
{
    delete ((const JPH::SoftBodySharedSettings::Vertex *)_this);
}

void JPH_SoftBodySharedSettings_Vertex_DestroyArray(const JPH_SoftBodySharedSettings_Vertex *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::Vertex *)_this);
}

JPH_SoftBodySharedSettings_Vertex *JPH_SoftBodySharedSettings_Vertex_AssignFromAnother(JPH_SoftBodySharedSettings_Vertex *_this, const JPH_SoftBodySharedSettings_Vertex *_other)
{
    return (JPH_SoftBodySharedSettings_Vertex *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Vertex *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Vertex(*(JPH::SoftBodySharedSettings::Vertex *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Vertex::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Vertex::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Vertex::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Vertex::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Vertex::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Vertex::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Vertex::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Vertex::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Vertex_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Vertex::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Vertex_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Vertex::operator delete[](
        inPointer,
        inPlace
    );
}

const unsigned int *JPH_SoftBodySharedSettings_Face_Get_mVertex(const JPH_SoftBodySharedSettings_Face *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Face *)(_this)).mVertex[0]);
}

unsigned int *JPH_SoftBodySharedSettings_Face_GetMutable_mVertex(JPH_SoftBodySharedSettings_Face *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Face *)(_this)).mVertex[0]);
}

size_t JPH_SoftBodySharedSettings_Face_GetSize_mVertex(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::Face::mVertex)>;
}

const unsigned int *JPH_SoftBodySharedSettings_Face_Get_mMaterialIndex(const JPH_SoftBodySharedSettings_Face *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Face *)(_this)).mMaterialIndex);
}

void JPH_SoftBodySharedSettings_Face_Set_mMaterialIndex(JPH_SoftBodySharedSettings_Face *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Face *)(_this)).mMaterialIndex = value;
}

unsigned int *JPH_SoftBodySharedSettings_Face_GetMutable_mMaterialIndex(JPH_SoftBodySharedSettings_Face *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Face *)(_this)).mMaterialIndex);
}

JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_Face *)new JPH::SoftBodySharedSettings::Face(JPH::SoftBodySharedSettings::Face());
}

JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_Face *)(new JPH::SoftBodySharedSettings::Face[num_elems]{});
}

const JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_OffsetPtr(const JPH_SoftBodySharedSettings_Face *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_Face *)(((const JPH::SoftBodySharedSettings::Face *)ptr) + i);
}

JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_OffsetMutablePtr(JPH_SoftBodySharedSettings_Face *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_Face *)(((JPH::SoftBodySharedSettings::Face *)ptr) + i);
}

JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_ConstructFromAnother(const JPH_SoftBodySharedSettings_Face *_other)
{
    return (JPH_SoftBodySharedSettings_Face *)new JPH::SoftBodySharedSettings::Face(JPH::SoftBodySharedSettings::Face(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Face(*(JPH::SoftBodySharedSettings::Face *)_other))
    ));
}

JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_Construct(unsigned int inVertex1, unsigned int inVertex2, unsigned int inVertex3, const unsigned int *inMaterialIndex)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_Face *)new JPH::SoftBodySharedSettings::Face(JPH::SoftBodySharedSettings::Face(
        inVertex1,
        inVertex2,
        inVertex3,
        (inMaterialIndex ? *inMaterialIndex : static_cast<unsigned int>(0))
    ));
}

void JPH_SoftBodySharedSettings_Face_Destroy(const JPH_SoftBodySharedSettings_Face *_this)
{
    delete ((const JPH::SoftBodySharedSettings::Face *)_this);
}

void JPH_SoftBodySharedSettings_Face_DestroyArray(const JPH_SoftBodySharedSettings_Face *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::Face *)_this);
}

JPH_SoftBodySharedSettings_Face *JPH_SoftBodySharedSettings_Face_AssignFromAnother(JPH_SoftBodySharedSettings_Face *_this, const JPH_SoftBodySharedSettings_Face *_other)
{
    return (JPH_SoftBodySharedSettings_Face *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Face *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Face(*(JPH::SoftBodySharedSettings::Face *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_Face_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Face::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Face::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Face::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Face::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Face::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Face::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_Face_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Face::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Face::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Face_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Face::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Face_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Face::operator delete[](
        inPointer,
        inPlace
    );
}

bool JPH_SoftBodySharedSettings_Face_IsDegenerate(const JPH_SoftBodySharedSettings_Face *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Face *)(_this)).IsDegenerate();
}

const unsigned int *JPH_SoftBodySharedSettings_Edge_Get_mVertex(const JPH_SoftBodySharedSettings_Edge *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Edge *)(_this)).mVertex[0]);
}

unsigned int *JPH_SoftBodySharedSettings_Edge_GetMutable_mVertex(JPH_SoftBodySharedSettings_Edge *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Edge *)(_this)).mVertex[0]);
}

size_t JPH_SoftBodySharedSettings_Edge_GetSize_mVertex(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::Edge::mVertex)>;
}

const float *JPH_SoftBodySharedSettings_Edge_Get_mRestLength(const JPH_SoftBodySharedSettings_Edge *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Edge *)(_this)).mRestLength);
}

void JPH_SoftBodySharedSettings_Edge_Set_mRestLength(JPH_SoftBodySharedSettings_Edge *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Edge *)(_this)).mRestLength = value;
}

float *JPH_SoftBodySharedSettings_Edge_GetMutable_mRestLength(JPH_SoftBodySharedSettings_Edge *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Edge *)(_this)).mRestLength);
}

const float *JPH_SoftBodySharedSettings_Edge_Get_mCompliance(const JPH_SoftBodySharedSettings_Edge *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Edge *)(_this)).mCompliance);
}

void JPH_SoftBodySharedSettings_Edge_Set_mCompliance(JPH_SoftBodySharedSettings_Edge *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Edge *)(_this)).mCompliance = value;
}

float *JPH_SoftBodySharedSettings_Edge_GetMutable_mCompliance(JPH_SoftBodySharedSettings_Edge *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Edge *)(_this)).mCompliance);
}

JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_Edge *)new JPH::SoftBodySharedSettings::Edge(JPH::SoftBodySharedSettings::Edge());
}

JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_Edge *)(new JPH::SoftBodySharedSettings::Edge[num_elems]{});
}

const JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_OffsetPtr(const JPH_SoftBodySharedSettings_Edge *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_Edge *)(((const JPH::SoftBodySharedSettings::Edge *)ptr) + i);
}

JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_OffsetMutablePtr(JPH_SoftBodySharedSettings_Edge *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_Edge *)(((JPH::SoftBodySharedSettings::Edge *)ptr) + i);
}

JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_ConstructFromAnother(const JPH_SoftBodySharedSettings_Edge *_other)
{
    return (JPH_SoftBodySharedSettings_Edge *)new JPH::SoftBodySharedSettings::Edge(JPH::SoftBodySharedSettings::Edge(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Edge(*(JPH::SoftBodySharedSettings::Edge *)_other))
    ));
}

JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_Construct(unsigned int inVertex1, unsigned int inVertex2, const float *inCompliance)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_Edge *)new JPH::SoftBodySharedSettings::Edge(JPH::SoftBodySharedSettings::Edge(
        inVertex1,
        inVertex2,
        (inCompliance ? *inCompliance : static_cast<float>(0.F))
    ));
}

void JPH_SoftBodySharedSettings_Edge_Destroy(const JPH_SoftBodySharedSettings_Edge *_this)
{
    delete ((const JPH::SoftBodySharedSettings::Edge *)_this);
}

void JPH_SoftBodySharedSettings_Edge_DestroyArray(const JPH_SoftBodySharedSettings_Edge *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::Edge *)_this);
}

JPH_SoftBodySharedSettings_Edge *JPH_SoftBodySharedSettings_Edge_AssignFromAnother(JPH_SoftBodySharedSettings_Edge *_this, const JPH_SoftBodySharedSettings_Edge *_other)
{
    return (JPH_SoftBodySharedSettings_Edge *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Edge *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Edge(*(JPH::SoftBodySharedSettings::Edge *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Edge::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Edge::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Edge::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Edge::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Edge::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Edge::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Edge::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Edge::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Edge_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Edge::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Edge_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Edge::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SoftBodySharedSettings_Edge_GetMinVertexIndex(const JPH_SoftBodySharedSettings_Edge *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Edge *)(_this)).GetMinVertexIndex();
}

const unsigned int *JPH_SoftBodySharedSettings_DihedralBend_Get_mVertex(const JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mVertex[0]);
}

unsigned int *JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mVertex(JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mVertex[0]);
}

size_t JPH_SoftBodySharedSettings_DihedralBend_GetSize_mVertex(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::DihedralBend::mVertex)>;
}

const float *JPH_SoftBodySharedSettings_DihedralBend_Get_mCompliance(const JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mCompliance);
}

void JPH_SoftBodySharedSettings_DihedralBend_Set_mCompliance(JPH_SoftBodySharedSettings_DihedralBend *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mCompliance = value;
}

float *JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mCompliance(JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mCompliance);
}

const float *JPH_SoftBodySharedSettings_DihedralBend_Get_mInitialAngle(const JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mInitialAngle);
}

void JPH_SoftBodySharedSettings_DihedralBend_Set_mInitialAngle(JPH_SoftBodySharedSettings_DihedralBend *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mInitialAngle = value;
}

float *JPH_SoftBodySharedSettings_DihedralBend_GetMutable_mInitialAngle(JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::DihedralBend *)(_this)).mInitialAngle);
}

JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)new JPH::SoftBodySharedSettings::DihedralBend(JPH::SoftBodySharedSettings::DihedralBend());
}

JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)(new JPH::SoftBodySharedSettings::DihedralBend[num_elems]{});
}

const JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_OffsetPtr(const JPH_SoftBodySharedSettings_DihedralBend *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_DihedralBend *)(((const JPH::SoftBodySharedSettings::DihedralBend *)ptr) + i);
}

JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_OffsetMutablePtr(JPH_SoftBodySharedSettings_DihedralBend *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)(((JPH::SoftBodySharedSettings::DihedralBend *)ptr) + i);
}

JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_ConstructFromAnother(const JPH_SoftBodySharedSettings_DihedralBend *_other)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)new JPH::SoftBodySharedSettings::DihedralBend(JPH::SoftBodySharedSettings::DihedralBend(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::DihedralBend(*(JPH::SoftBodySharedSettings::DihedralBend *)_other))
    ));
}

JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_Construct(unsigned int inVertex1, unsigned int inVertex2, unsigned int inVertex3, unsigned int inVertex4, const float *inCompliance)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_DihedralBend *)new JPH::SoftBodySharedSettings::DihedralBend(JPH::SoftBodySharedSettings::DihedralBend(
        inVertex1,
        inVertex2,
        inVertex3,
        inVertex4,
        (inCompliance ? *inCompliance : static_cast<float>(0.F))
    ));
}

void JPH_SoftBodySharedSettings_DihedralBend_Destroy(const JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    delete ((const JPH::SoftBodySharedSettings::DihedralBend *)_this);
}

void JPH_SoftBodySharedSettings_DihedralBend_DestroyArray(const JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::DihedralBend *)_this);
}

JPH_SoftBodySharedSettings_DihedralBend *JPH_SoftBodySharedSettings_DihedralBend_AssignFromAnother(JPH_SoftBodySharedSettings_DihedralBend *_this, const JPH_SoftBodySharedSettings_DihedralBend *_other)
{
    return (JPH_SoftBodySharedSettings_DihedralBend *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::DihedralBend *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::DihedralBend(*(JPH::SoftBodySharedSettings::DihedralBend *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::DihedralBend::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::DihedralBend::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::DihedralBend::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::DihedralBend::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::DihedralBend::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::DihedralBend::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::DihedralBend::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::DihedralBend::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_DihedralBend_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::DihedralBend::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_DihedralBend_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::DihedralBend::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SoftBodySharedSettings_DihedralBend_GetMinVertexIndex(const JPH_SoftBodySharedSettings_DihedralBend *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::DihedralBend *)(_this)).GetMinVertexIndex();
}

const unsigned int *JPH_SoftBodySharedSettings_Volume_Get_mVertex(const JPH_SoftBodySharedSettings_Volume *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Volume *)(_this)).mVertex[0]);
}

unsigned int *JPH_SoftBodySharedSettings_Volume_GetMutable_mVertex(JPH_SoftBodySharedSettings_Volume *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Volume *)(_this)).mVertex[0]);
}

size_t JPH_SoftBodySharedSettings_Volume_GetSize_mVertex(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::Volume::mVertex)>;
}

const float *JPH_SoftBodySharedSettings_Volume_Get_mSixRestVolume(const JPH_SoftBodySharedSettings_Volume *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Volume *)(_this)).mSixRestVolume);
}

void JPH_SoftBodySharedSettings_Volume_Set_mSixRestVolume(JPH_SoftBodySharedSettings_Volume *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Volume *)(_this)).mSixRestVolume = value;
}

float *JPH_SoftBodySharedSettings_Volume_GetMutable_mSixRestVolume(JPH_SoftBodySharedSettings_Volume *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Volume *)(_this)).mSixRestVolume);
}

const float *JPH_SoftBodySharedSettings_Volume_Get_mCompliance(const JPH_SoftBodySharedSettings_Volume *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Volume *)(_this)).mCompliance);
}

void JPH_SoftBodySharedSettings_Volume_Set_mCompliance(JPH_SoftBodySharedSettings_Volume *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Volume *)(_this)).mCompliance = value;
}

float *JPH_SoftBodySharedSettings_Volume_GetMutable_mCompliance(JPH_SoftBodySharedSettings_Volume *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Volume *)(_this)).mCompliance);
}

JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_Volume *)new JPH::SoftBodySharedSettings::Volume(JPH::SoftBodySharedSettings::Volume());
}

JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_Volume *)(new JPH::SoftBodySharedSettings::Volume[num_elems]{});
}

const JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_OffsetPtr(const JPH_SoftBodySharedSettings_Volume *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_Volume *)(((const JPH::SoftBodySharedSettings::Volume *)ptr) + i);
}

JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_OffsetMutablePtr(JPH_SoftBodySharedSettings_Volume *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_Volume *)(((JPH::SoftBodySharedSettings::Volume *)ptr) + i);
}

JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_ConstructFromAnother(const JPH_SoftBodySharedSettings_Volume *_other)
{
    return (JPH_SoftBodySharedSettings_Volume *)new JPH::SoftBodySharedSettings::Volume(JPH::SoftBodySharedSettings::Volume(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Volume(*(JPH::SoftBodySharedSettings::Volume *)_other))
    ));
}

JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_Construct(unsigned int inVertex1, unsigned int inVertex2, unsigned int inVertex3, unsigned int inVertex4, const float *inCompliance)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_Volume *)new JPH::SoftBodySharedSettings::Volume(JPH::SoftBodySharedSettings::Volume(
        inVertex1,
        inVertex2,
        inVertex3,
        inVertex4,
        (inCompliance ? *inCompliance : static_cast<float>(0.F))
    ));
}

void JPH_SoftBodySharedSettings_Volume_Destroy(const JPH_SoftBodySharedSettings_Volume *_this)
{
    delete ((const JPH::SoftBodySharedSettings::Volume *)_this);
}

void JPH_SoftBodySharedSettings_Volume_DestroyArray(const JPH_SoftBodySharedSettings_Volume *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::Volume *)_this);
}

JPH_SoftBodySharedSettings_Volume *JPH_SoftBodySharedSettings_Volume_AssignFromAnother(JPH_SoftBodySharedSettings_Volume *_this, const JPH_SoftBodySharedSettings_Volume *_other)
{
    return (JPH_SoftBodySharedSettings_Volume *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Volume *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Volume(*(JPH::SoftBodySharedSettings::Volume *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Volume::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Volume::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Volume::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Volume::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Volume::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Volume::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Volume::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Volume::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Volume_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Volume::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Volume_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Volume::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SoftBodySharedSettings_Volume_GetMinVertexIndex(const JPH_SoftBodySharedSettings_Volume *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Volume *)(_this)).GetMinVertexIndex();
}

const unsigned int *JPH_SoftBodySharedSettings_InvBind_Get_mJointIndex(const JPH_SoftBodySharedSettings_InvBind *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::InvBind *)(_this)).mJointIndex);
}

void JPH_SoftBodySharedSettings_InvBind_Set_mJointIndex(JPH_SoftBodySharedSettings_InvBind *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::InvBind *)(_this)).mJointIndex = value;
}

unsigned int *JPH_SoftBodySharedSettings_InvBind_GetMutable_mJointIndex(JPH_SoftBodySharedSettings_InvBind *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::InvBind *)(_this)).mJointIndex);
}

const JPH_Mat44 *JPH_SoftBodySharedSettings_InvBind_Get_mInvBind(const JPH_SoftBodySharedSettings_InvBind *_this)
{
    return (const JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::InvBind *)(_this)).mInvBind);
}

JPH_Mat44 *JPH_SoftBodySharedSettings_InvBind_GetMutable_mInvBind(JPH_SoftBodySharedSettings_InvBind *_this)
{
    return (JPH_Mat44 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::InvBind *)(_this)).mInvBind);
}

JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_InvBind *)new JPH::SoftBodySharedSettings::InvBind(JPH::SoftBodySharedSettings::InvBind());
}

JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_InvBind *)(new JPH::SoftBodySharedSettings::InvBind[num_elems]{});
}

const JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_OffsetPtr(const JPH_SoftBodySharedSettings_InvBind *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_InvBind *)(((const JPH::SoftBodySharedSettings::InvBind *)ptr) + i);
}

JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_OffsetMutablePtr(JPH_SoftBodySharedSettings_InvBind *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_InvBind *)(((JPH::SoftBodySharedSettings::InvBind *)ptr) + i);
}

JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_ConstructFromAnother(const JPH_SoftBodySharedSettings_InvBind *_other)
{
    return (JPH_SoftBodySharedSettings_InvBind *)new JPH::SoftBodySharedSettings::InvBind(JPH::SoftBodySharedSettings::InvBind(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::InvBind(*(JPH::SoftBodySharedSettings::InvBind *)_other))
    ));
}

JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_Construct(unsigned int inJointIndex, const JPH_Mat44 *inInvBind)
{
    return (JPH_SoftBodySharedSettings_InvBind *)new JPH::SoftBodySharedSettings::InvBind(JPH::SoftBodySharedSettings::InvBind(
        inJointIndex,
        ((inInvBind ? void() : MRBINDC_THROW("Parameter `inInvBind` can not be null.", void)), *(const JPH::Mat44 *)(inInvBind))
    ));
}

void JPH_SoftBodySharedSettings_InvBind_Destroy(const JPH_SoftBodySharedSettings_InvBind *_this)
{
    delete ((const JPH::SoftBodySharedSettings::InvBind *)_this);
}

void JPH_SoftBodySharedSettings_InvBind_DestroyArray(const JPH_SoftBodySharedSettings_InvBind *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::InvBind *)_this);
}

JPH_SoftBodySharedSettings_InvBind *JPH_SoftBodySharedSettings_InvBind_AssignFromAnother(JPH_SoftBodySharedSettings_InvBind *_this, const JPH_SoftBodySharedSettings_InvBind *_other)
{
    return (JPH_SoftBodySharedSettings_InvBind *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::InvBind *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::InvBind(*(JPH::SoftBodySharedSettings::InvBind *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::InvBind::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::InvBind::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::InvBind::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::InvBind::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::InvBind::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::InvBind::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::InvBind::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::InvBind::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_InvBind_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::InvBind::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_InvBind_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::InvBind::operator delete[](
        inPointer,
        inPlace
    );
}

const unsigned int *JPH_SoftBodySharedSettings_SkinWeight_Get_mInvBindIndex(const JPH_SoftBodySharedSettings_SkinWeight *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::SkinWeight *)(_this)).mInvBindIndex);
}

void JPH_SoftBodySharedSettings_SkinWeight_Set_mInvBindIndex(JPH_SoftBodySharedSettings_SkinWeight *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::SkinWeight *)(_this)).mInvBindIndex = value;
}

unsigned int *JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mInvBindIndex(JPH_SoftBodySharedSettings_SkinWeight *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::SkinWeight *)(_this)).mInvBindIndex);
}

const float *JPH_SoftBodySharedSettings_SkinWeight_Get_mWeight(const JPH_SoftBodySharedSettings_SkinWeight *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::SkinWeight *)(_this)).mWeight);
}

void JPH_SoftBodySharedSettings_SkinWeight_Set_mWeight(JPH_SoftBodySharedSettings_SkinWeight *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::SkinWeight *)(_this)).mWeight = value;
}

float *JPH_SoftBodySharedSettings_SkinWeight_GetMutable_mWeight(JPH_SoftBodySharedSettings_SkinWeight *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::SkinWeight *)(_this)).mWeight);
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)new JPH::SoftBodySharedSettings::SkinWeight(JPH::SoftBodySharedSettings::SkinWeight());
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)(new JPH::SoftBodySharedSettings::SkinWeight[num_elems]{});
}

const JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_OffsetPtr(const JPH_SoftBodySharedSettings_SkinWeight *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_SkinWeight *)(((const JPH::SoftBodySharedSettings::SkinWeight *)ptr) + i);
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_OffsetMutablePtr(JPH_SoftBodySharedSettings_SkinWeight *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)(((JPH::SoftBodySharedSettings::SkinWeight *)ptr) + i);
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_ConstructFromAnother(const JPH_SoftBodySharedSettings_SkinWeight *_other)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)new JPH::SoftBodySharedSettings::SkinWeight(JPH::SoftBodySharedSettings::SkinWeight(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::SkinWeight(*(JPH::SoftBodySharedSettings::SkinWeight *)_other))
    ));
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_Construct(unsigned int inInvBindIndex, float inWeight)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)new JPH::SoftBodySharedSettings::SkinWeight(JPH::SoftBodySharedSettings::SkinWeight(
        inInvBindIndex,
        inWeight
    ));
}

void JPH_SoftBodySharedSettings_SkinWeight_Destroy(const JPH_SoftBodySharedSettings_SkinWeight *_this)
{
    delete ((const JPH::SoftBodySharedSettings::SkinWeight *)_this);
}

void JPH_SoftBodySharedSettings_SkinWeight_DestroyArray(const JPH_SoftBodySharedSettings_SkinWeight *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::SkinWeight *)_this);
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_SkinWeight_AssignFromAnother(JPH_SoftBodySharedSettings_SkinWeight *_this, const JPH_SoftBodySharedSettings_SkinWeight *_other)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::SkinWeight *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::SkinWeight(*(JPH::SoftBodySharedSettings::SkinWeight *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::SkinWeight::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::SkinWeight::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::SkinWeight::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::SkinWeight::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::SkinWeight::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::SkinWeight::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::SkinWeight::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::SkinWeight::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_SkinWeight_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::SkinWeight::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_SkinWeight_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::SkinWeight::operator delete[](
        inPointer,
        inPlace
    );
}

const unsigned int *JPH_SoftBodySharedSettings_Skinned_Get_cMaxSkinWeights(void)
{
    return std::addressof(JPH::SoftBodySharedSettings::Skinned::cMaxSkinWeights);
}

const unsigned int *JPH_SoftBodySharedSettings_Skinned_Get_mVertex(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(_this)).mVertex);
}

void JPH_SoftBodySharedSettings_Skinned_Set_mVertex(JPH_SoftBodySharedSettings_Skinned *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mVertex = value;
}

unsigned int *JPH_SoftBodySharedSettings_Skinned_GetMutable_mVertex(JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mVertex);
}

const JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_Skinned_Get_mWeights(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    return (const JPH_SoftBodySharedSettings_SkinWeight *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(_this)).mWeights[0]);
}

JPH_SoftBodySharedSettings_SkinWeight *JPH_SoftBodySharedSettings_Skinned_GetMutable_mWeights(JPH_SoftBodySharedSettings_Skinned *_this)
{
    return (JPH_SoftBodySharedSettings_SkinWeight *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mWeights[0]);
}

size_t JPH_SoftBodySharedSettings_Skinned_GetSize_mWeights(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::Skinned::mWeights)>;
}

const float *JPH_SoftBodySharedSettings_Skinned_Get_mMaxDistance(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(_this)).mMaxDistance);
}

void JPH_SoftBodySharedSettings_Skinned_Set_mMaxDistance(JPH_SoftBodySharedSettings_Skinned *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mMaxDistance = value;
}

float *JPH_SoftBodySharedSettings_Skinned_GetMutable_mMaxDistance(JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mMaxDistance);
}

const float *JPH_SoftBodySharedSettings_Skinned_Get_mBackStopDistance(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(_this)).mBackStopDistance);
}

void JPH_SoftBodySharedSettings_Skinned_Set_mBackStopDistance(JPH_SoftBodySharedSettings_Skinned *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mBackStopDistance = value;
}

float *JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopDistance(JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mBackStopDistance);
}

const float *JPH_SoftBodySharedSettings_Skinned_Get_mBackStopRadius(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(_this)).mBackStopRadius);
}

void JPH_SoftBodySharedSettings_Skinned_Set_mBackStopRadius(JPH_SoftBodySharedSettings_Skinned *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mBackStopRadius = value;
}

float *JPH_SoftBodySharedSettings_Skinned_GetMutable_mBackStopRadius(JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mBackStopRadius);
}

const unsigned int *JPH_SoftBodySharedSettings_Skinned_Get_mNormalInfo(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::Skinned *)(_this)).mNormalInfo);
}

void JPH_SoftBodySharedSettings_Skinned_Set_mNormalInfo(JPH_SoftBodySharedSettings_Skinned *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mNormalInfo = value;
}

unsigned int *JPH_SoftBodySharedSettings_Skinned_GetMutable_mNormalInfo(JPH_SoftBodySharedSettings_Skinned *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).mNormalInfo);
}

JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_Skinned *)new JPH::SoftBodySharedSettings::Skinned(JPH::SoftBodySharedSettings::Skinned());
}

JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_Skinned *)(new JPH::SoftBodySharedSettings::Skinned[num_elems]{});
}

const JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_OffsetPtr(const JPH_SoftBodySharedSettings_Skinned *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_Skinned *)(((const JPH::SoftBodySharedSettings::Skinned *)ptr) + i);
}

JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_OffsetMutablePtr(JPH_SoftBodySharedSettings_Skinned *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_Skinned *)(((JPH::SoftBodySharedSettings::Skinned *)ptr) + i);
}

JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_ConstructFromAnother(const JPH_SoftBodySharedSettings_Skinned *_other)
{
    return (JPH_SoftBodySharedSettings_Skinned *)new JPH::SoftBodySharedSettings::Skinned(JPH::SoftBodySharedSettings::Skinned(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Skinned(*(JPH::SoftBodySharedSettings::Skinned *)_other))
    ));
}

JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_Construct(unsigned int inVertex, float inMaxDistance, float inBackStopDistance, float inBackStopRadius)
{
    return (JPH_SoftBodySharedSettings_Skinned *)new JPH::SoftBodySharedSettings::Skinned(JPH::SoftBodySharedSettings::Skinned(
        inVertex,
        inMaxDistance,
        inBackStopDistance,
        inBackStopRadius
    ));
}

void JPH_SoftBodySharedSettings_Skinned_Destroy(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    delete ((const JPH::SoftBodySharedSettings::Skinned *)_this);
}

void JPH_SoftBodySharedSettings_Skinned_DestroyArray(const JPH_SoftBodySharedSettings_Skinned *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::Skinned *)_this);
}

JPH_SoftBodySharedSettings_Skinned *JPH_SoftBodySharedSettings_Skinned_AssignFromAnother(JPH_SoftBodySharedSettings_Skinned *_this, const JPH_SoftBodySharedSettings_Skinned *_other)
{
    return (JPH_SoftBodySharedSettings_Skinned *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::Skinned(*(JPH::SoftBodySharedSettings::Skinned *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Skinned::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Skinned::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Skinned::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::Skinned::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::Skinned::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::Skinned::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Skinned::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Skinned::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_Skinned_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::Skinned::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_Skinned_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::Skinned::operator delete[](
        inPointer,
        inPlace
    );
}

void JPH_SoftBodySharedSettings_Skinned_NormalizeWeights(JPH_SoftBodySharedSettings_Skinned *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::Skinned *)(_this)).NormalizeWeights();
}

const unsigned int *JPH_SoftBodySharedSettings_LRA_Get_mVertex(const JPH_SoftBodySharedSettings_LRA *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::LRA *)(_this)).mVertex[0]);
}

unsigned int *JPH_SoftBodySharedSettings_LRA_GetMutable_mVertex(JPH_SoftBodySharedSettings_LRA *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::LRA *)(_this)).mVertex[0]);
}

size_t JPH_SoftBodySharedSettings_LRA_GetSize_mVertex(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::LRA::mVertex)>;
}

const float *JPH_SoftBodySharedSettings_LRA_Get_mMaxDistance(const JPH_SoftBodySharedSettings_LRA *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::LRA *)(_this)).mMaxDistance);
}

void JPH_SoftBodySharedSettings_LRA_Set_mMaxDistance(JPH_SoftBodySharedSettings_LRA *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::LRA *)(_this)).mMaxDistance = value;
}

float *JPH_SoftBodySharedSettings_LRA_GetMutable_mMaxDistance(JPH_SoftBodySharedSettings_LRA *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::LRA *)(_this)).mMaxDistance);
}

JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_LRA *)new JPH::SoftBodySharedSettings::LRA(JPH::SoftBodySharedSettings::LRA());
}

JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_LRA *)(new JPH::SoftBodySharedSettings::LRA[num_elems]{});
}

const JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_OffsetPtr(const JPH_SoftBodySharedSettings_LRA *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_LRA *)(((const JPH::SoftBodySharedSettings::LRA *)ptr) + i);
}

JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_OffsetMutablePtr(JPH_SoftBodySharedSettings_LRA *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_LRA *)(((JPH::SoftBodySharedSettings::LRA *)ptr) + i);
}

JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_ConstructFromAnother(const JPH_SoftBodySharedSettings_LRA *_other)
{
    return (JPH_SoftBodySharedSettings_LRA *)new JPH::SoftBodySharedSettings::LRA(JPH::SoftBodySharedSettings::LRA(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::LRA(*(JPH::SoftBodySharedSettings::LRA *)_other))
    ));
}

JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_Construct(unsigned int inVertex1, unsigned int inVertex2, float inMaxDistance)
{
    return (JPH_SoftBodySharedSettings_LRA *)new JPH::SoftBodySharedSettings::LRA(JPH::SoftBodySharedSettings::LRA(
        inVertex1,
        inVertex2,
        inMaxDistance
    ));
}

void JPH_SoftBodySharedSettings_LRA_Destroy(const JPH_SoftBodySharedSettings_LRA *_this)
{
    delete ((const JPH::SoftBodySharedSettings::LRA *)_this);
}

void JPH_SoftBodySharedSettings_LRA_DestroyArray(const JPH_SoftBodySharedSettings_LRA *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::LRA *)_this);
}

JPH_SoftBodySharedSettings_LRA *JPH_SoftBodySharedSettings_LRA_AssignFromAnother(JPH_SoftBodySharedSettings_LRA *_this, const JPH_SoftBodySharedSettings_LRA *_other)
{
    return (JPH_SoftBodySharedSettings_LRA *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::LRA *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::LRA(*(JPH::SoftBodySharedSettings::LRA *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::LRA::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::LRA::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::LRA::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::LRA::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::LRA::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::LRA::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::LRA::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::LRA::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_LRA_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::LRA::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_LRA_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::LRA::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SoftBodySharedSettings_LRA_GetMinVertexIndex(const JPH_SoftBodySharedSettings_LRA *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::LRA *)(_this)).GetMinVertexIndex();
}

const unsigned int *JPH_SoftBodySharedSettings_RodStretchShear_Get_mVertex(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mVertex[0]);
}

unsigned int *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mVertex(JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mVertex[0]);
}

size_t JPH_SoftBodySharedSettings_RodStretchShear_GetSize_mVertex(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::RodStretchShear::mVertex)>;
}

const float *JPH_SoftBodySharedSettings_RodStretchShear_Get_mLength(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mLength);
}

void JPH_SoftBodySharedSettings_RodStretchShear_Set_mLength(JPH_SoftBodySharedSettings_RodStretchShear *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mLength = value;
}

float *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mLength(JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mLength);
}

const float *JPH_SoftBodySharedSettings_RodStretchShear_Get_mInvMass(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mInvMass);
}

void JPH_SoftBodySharedSettings_RodStretchShear_Set_mInvMass(JPH_SoftBodySharedSettings_RodStretchShear *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mInvMass = value;
}

float *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mInvMass(JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mInvMass);
}

const float *JPH_SoftBodySharedSettings_RodStretchShear_Get_mCompliance(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mCompliance);
}

void JPH_SoftBodySharedSettings_RodStretchShear_Set_mCompliance(JPH_SoftBodySharedSettings_RodStretchShear *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mCompliance = value;
}

float *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mCompliance(JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mCompliance);
}

const JPH_Quat *JPH_SoftBodySharedSettings_RodStretchShear_Get_mBishop(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mBishop);
}

JPH_Quat *JPH_SoftBodySharedSettings_RodStretchShear_GetMutable_mBishop(JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).mBishop);
}

JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)new JPH::SoftBodySharedSettings::RodStretchShear(JPH::SoftBodySharedSettings::RodStretchShear());
}

JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)(new JPH::SoftBodySharedSettings::RodStretchShear[num_elems]{});
}

const JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_OffsetPtr(const JPH_SoftBodySharedSettings_RodStretchShear *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_RodStretchShear *)(((const JPH::SoftBodySharedSettings::RodStretchShear *)ptr) + i);
}

JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_OffsetMutablePtr(JPH_SoftBodySharedSettings_RodStretchShear *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)(((JPH::SoftBodySharedSettings::RodStretchShear *)ptr) + i);
}

JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_ConstructFromAnother(const JPH_SoftBodySharedSettings_RodStretchShear *_other)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)new JPH::SoftBodySharedSettings::RodStretchShear(JPH::SoftBodySharedSettings::RodStretchShear(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::RodStretchShear(*(JPH::SoftBodySharedSettings::RodStretchShear *)_other))
    ));
}

JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_Construct(unsigned int inVertex1, unsigned int inVertex2, const float *inCompliance)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_RodStretchShear *)new JPH::SoftBodySharedSettings::RodStretchShear(JPH::SoftBodySharedSettings::RodStretchShear(
        inVertex1,
        inVertex2,
        (inCompliance ? *inCompliance : static_cast<float>(0.F))
    ));
}

void JPH_SoftBodySharedSettings_RodStretchShear_Destroy(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    delete ((const JPH::SoftBodySharedSettings::RodStretchShear *)_this);
}

void JPH_SoftBodySharedSettings_RodStretchShear_DestroyArray(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::RodStretchShear *)_this);
}

JPH_SoftBodySharedSettings_RodStretchShear *JPH_SoftBodySharedSettings_RodStretchShear_AssignFromAnother(JPH_SoftBodySharedSettings_RodStretchShear *_this, const JPH_SoftBodySharedSettings_RodStretchShear *_other)
{
    return (JPH_SoftBodySharedSettings_RodStretchShear *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::RodStretchShear(*(JPH::SoftBodySharedSettings::RodStretchShear *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::RodStretchShear::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::RodStretchShear::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::RodStretchShear::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::RodStretchShear::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::RodStretchShear::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::RodStretchShear::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::RodStretchShear::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::RodStretchShear::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_RodStretchShear_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::RodStretchShear::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_RodStretchShear_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::RodStretchShear::operator delete[](
        inPointer,
        inPlace
    );
}

unsigned int JPH_SoftBodySharedSettings_RodStretchShear_GetMinVertexIndex(const JPH_SoftBodySharedSettings_RodStretchShear *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodStretchShear *)(_this)).GetMinVertexIndex();
}

const unsigned int *JPH_SoftBodySharedSettings_RodBendTwist_Get_mRod(const JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mRod[0]);
}

unsigned int *JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mRod(JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mRod[0]);
}

size_t JPH_SoftBodySharedSettings_RodBendTwist_GetSize_mRod(void)
{
    return std::extent_v<decltype(JPH::SoftBodySharedSettings::RodBendTwist::mRod)>;
}

const float *JPH_SoftBodySharedSettings_RodBendTwist_Get_mCompliance(const JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mCompliance);
}

void JPH_SoftBodySharedSettings_RodBendTwist_Set_mCompliance(JPH_SoftBodySharedSettings_RodBendTwist *_this, float value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mCompliance = value;
}

float *JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mCompliance(JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mCompliance);
}

const JPH_Quat *JPH_SoftBodySharedSettings_RodBendTwist_Get_mOmega0(const JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return (const JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mOmega0);
}

JPH_Quat *JPH_SoftBodySharedSettings_RodBendTwist_GetMutable_mOmega0(JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    return (JPH_Quat *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).mOmega0);
}

JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstruct(void)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)new JPH::SoftBodySharedSettings::RodBendTwist(JPH::SoftBodySharedSettings::RodBendTwist());
}

JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_DefaultConstructArray(size_t num_elems)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)(new JPH::SoftBodySharedSettings::RodBendTwist[num_elems]{});
}

const JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_OffsetPtr(const JPH_SoftBodySharedSettings_RodBendTwist *ptr, ptrdiff_t i)
{
    return (const JPH_SoftBodySharedSettings_RodBendTwist *)(((const JPH::SoftBodySharedSettings::RodBendTwist *)ptr) + i);
}

JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_OffsetMutablePtr(JPH_SoftBodySharedSettings_RodBendTwist *ptr, ptrdiff_t i)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)(((JPH::SoftBodySharedSettings::RodBendTwist *)ptr) + i);
}

JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_ConstructFromAnother(const JPH_SoftBodySharedSettings_RodBendTwist *_other)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)new JPH::SoftBodySharedSettings::RodBendTwist(JPH::SoftBodySharedSettings::RodBendTwist(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::RodBendTwist(*(JPH::SoftBodySharedSettings::RodBendTwist *)_other))
    ));
}

JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_Construct(unsigned int inRod1, unsigned int inRod2, const float *inCompliance)
{
    using namespace JPH;
    return (JPH_SoftBodySharedSettings_RodBendTwist *)new JPH::SoftBodySharedSettings::RodBendTwist(JPH::SoftBodySharedSettings::RodBendTwist(
        inRod1,
        inRod2,
        (inCompliance ? *inCompliance : static_cast<float>(0.F))
    ));
}

void JPH_SoftBodySharedSettings_RodBendTwist_Destroy(const JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    delete ((const JPH::SoftBodySharedSettings::RodBendTwist *)_this);
}

void JPH_SoftBodySharedSettings_RodBendTwist_DestroyArray(const JPH_SoftBodySharedSettings_RodBendTwist *_this)
{
    delete[] ((const JPH::SoftBodySharedSettings::RodBendTwist *)_this);
}

JPH_SoftBodySharedSettings_RodBendTwist *JPH_SoftBodySharedSettings_RodBendTwist_AssignFromAnother(JPH_SoftBodySharedSettings_RodBendTwist *_this, const JPH_SoftBodySharedSettings_RodBendTwist *_other)
{
    return (JPH_SoftBodySharedSettings_RodBendTwist *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(JPH::SoftBodySharedSettings::RodBendTwist *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), JPH::SoftBodySharedSettings::RodBendTwist(*(JPH::SoftBodySharedSettings::RodBendTwist *)_other))
    ));
}

void *Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::RodBendTwist::operator new(
        inCount
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::RodBendTwist::operator delete(
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::RodBendTwist::operator delete(
        inPointer,
        inSize
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t(unsigned long inCount)
{
    return JPH::SoftBodySharedSettings::RodBendTwist::operator new[](
        inCount
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr(void *inPointer)
{
    JPH::SoftBodySharedSettings::RodBendTwist::operator delete[](
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_size_t(void *inPointer, unsigned long inSize)
{
    JPH::SoftBodySharedSettings::RodBendTwist::operator delete[](
        inPointer,
        inSize
    );
}

void *Jolt_new_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::RodBendTwist::operator new(
        inCount,
        inPointer
    );
}

void Jolt_delete_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::RodBendTwist::operator delete(
        inPointer,
        inPlace
    );
}

void *Jolt_new_array_JPH_SoftBodySharedSettings_RodBendTwist_size_t_void_ptr(unsigned long inCount, void *inPointer)
{
    return JPH::SoftBodySharedSettings::RodBendTwist::operator new[](
        inCount,
        inPointer
    );
}

void Jolt_delete_array_JPH_SoftBodySharedSettings_RodBendTwist_void_ptr_void_ptr(void *inPointer, void *inPlace)
{
    JPH::SoftBodySharedSettings::RodBendTwist::operator delete[](
        inPointer,
        inPlace
    );
}

