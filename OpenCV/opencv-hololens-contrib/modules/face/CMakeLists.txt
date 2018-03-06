set(the_description "Face recognition etc")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(face opencv_core opencv_imgproc opencv_objdetect WRAP python)
# NOTE: objdetect module is needed for one of the samples
