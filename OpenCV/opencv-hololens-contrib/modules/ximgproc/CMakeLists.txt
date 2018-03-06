set(the_description "Extended image processing module. It includes edge-aware filters and etc.")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(ximgproc opencv_core opencv_imgproc opencv_calib3d opencv_imgcodecs WRAP python)
