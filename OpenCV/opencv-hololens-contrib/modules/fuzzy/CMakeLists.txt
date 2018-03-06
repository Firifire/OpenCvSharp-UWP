set(the_description "Fuzzy mathematical image processing")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(fuzzy opencv_imgproc opencv_core WRAP python)
