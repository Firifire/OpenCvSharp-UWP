set(the_description "Image Processing")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_add_dispatched_file(accum SSE2 AVX NEON)
ocv_define_module(imgproc opencv_core WRAP java python js)
