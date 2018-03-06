set(the_description "Line descriptor")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(line_descriptor opencv_imgproc OPTIONAL opencv_features2d WRAP python)
