set(the_description "Background Segmentation Algorithms")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(bgsegm opencv_core opencv_imgproc opencv_video WRAP python)
