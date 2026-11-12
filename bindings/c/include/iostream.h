// machine generated, do not edit
#pragma once

#include <exports.h>

#ifdef __cplusplus
extern "C" {
#endif


/// A C++ output stream.
typedef struct Jolt_std_ostream Jolt_std_ostream;

/// A C++ input stream.
typedef struct Jolt_std_istream Jolt_std_istream;

/// Returns the `stdout` stream.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_GetStdCout(void);

/// Returns the `stderr` stream, buffered.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_GetStdCerr(void);

/// Returns the `stderr` stream, unbuffered.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_ostream *Jolt_GetStdClog(void);

/// Returns the `stdin` stream.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
JOLT_API Jolt_std_istream *Jolt_GetStdCin(void);

#ifdef __cplusplus
} // extern "C"
#endif
