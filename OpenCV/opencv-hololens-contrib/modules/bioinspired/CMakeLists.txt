set(the_description "Biologically inspired algorithms")
ocv_warnings_disable(CMAKE_CXX_FLAGS -Wundef)

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(bioinspired opencv_core OPTIONAL opencv_highgui opencv_ocl WRAP java python)
