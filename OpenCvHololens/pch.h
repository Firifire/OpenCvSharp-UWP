#pragma once

#include "targetver.h"

#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN
#endif

#include <windows.h>

#ifndef CVAPI
#define CVAPI extern "C" int __declspec(dllexport) __stdcall
#endif