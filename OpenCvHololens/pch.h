#pragma once

#include "targetver.h"

#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN
#endif

#include <windows.h>

#ifndef CVAPI
#define CVAPI(rettype) CV_EXTERN_C CV_EXPORTS rettype CV_CDECL
#endif