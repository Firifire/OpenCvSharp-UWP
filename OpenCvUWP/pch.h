#pragma once

#include "targetver.h"


#ifndef _UWP
#define _UWP

#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN
#endif

#ifndef _CPP_DNN_H_
#define _CPP_DNN_H_
#endif

#ifndef _CPP_DNN_NET_H_
#define _CPP_DNN_NET_H_
#endif

#ifndef _CPP_SUPERRES_H_
#define _CPP_SUPERRES_H_
#endif

#endif

#include <windows.h>

#ifndef CVAPI
#define CVAPI(rettype) CV_EXTERN_C CV_EXPORTS rettype CV_STDCALL
#endif

#ifndef OldAPI
#  define OldAPI(rettype) CV_EXTERN_C CV_EXPORTS rettype CV_CDECL
#endif