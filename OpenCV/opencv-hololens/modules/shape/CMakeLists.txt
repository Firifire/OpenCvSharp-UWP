set(the_description "Shape descriptors and matchers")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(shape opencv_core opencv_imgproc opencv_video WRAP python)
