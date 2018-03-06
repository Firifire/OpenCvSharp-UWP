set(the_description "Image hash algorithms")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

set(OPENCV_MODULE_IS_PART_OF_WORLD OFF)
ocv_define_module(img_hash opencv_imgproc opencv_core WRAP java python)
