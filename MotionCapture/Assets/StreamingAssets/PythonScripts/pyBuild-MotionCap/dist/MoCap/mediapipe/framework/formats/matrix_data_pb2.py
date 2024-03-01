# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mediapipe/framework/formats/matrix_data.proto
"""Generated protocol buffer code."""
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='mediapipe/framework/formats/matrix_data.proto',
  package='mediapipe',
  syntax='proto2',
  serialized_options=b'\n\"com.google.mediapipe.formats.protoB\017MatrixDataProto',
  create_key=_descriptor._internal_create_key,
  serialized_pb=b'\n-mediapipe/framework/formats/matrix_data.proto\x12\tmediapipe\"\xa8\x01\n\nMatrixData\x12\x0c\n\x04rows\x18\x01 \x01(\x05\x12\x0c\n\x04\x63ols\x18\x02 \x01(\x05\x12\x17\n\x0bpacked_data\x18\x03 \x03(\x02\x42\x02\x10\x01\x12:\n\x06layout\x18\x04 \x01(\x0e\x32\x1c.mediapipe.MatrixData.Layout:\x0c\x43OLUMN_MAJOR\")\n\x06Layout\x12\x10\n\x0c\x43OLUMN_MAJOR\x10\x00\x12\r\n\tROW_MAJOR\x10\x01\x42\x35\n\"com.google.mediapipe.formats.protoB\x0fMatrixDataProto'
)



_MATRIXDATA_LAYOUT = _descriptor.EnumDescriptor(
  name='Layout',
  full_name='mediapipe.MatrixData.Layout',
  filename=None,
  file=DESCRIPTOR,
  create_key=_descriptor._internal_create_key,
  values=[
    _descriptor.EnumValueDescriptor(
      name='COLUMN_MAJOR', index=0, number=0,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
    _descriptor.EnumValueDescriptor(
      name='ROW_MAJOR', index=1, number=1,
      serialized_options=None,
      type=None,
      create_key=_descriptor._internal_create_key),
  ],
  containing_type=None,
  serialized_options=None,
  serialized_start=188,
  serialized_end=229,
)
_sym_db.RegisterEnumDescriptor(_MATRIXDATA_LAYOUT)


_MATRIXDATA = _descriptor.Descriptor(
  name='MatrixData',
  full_name='mediapipe.MatrixData',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  create_key=_descriptor._internal_create_key,
  fields=[
    _descriptor.FieldDescriptor(
      name='rows', full_name='mediapipe.MatrixData.rows', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='cols', full_name='mediapipe.MatrixData.cols', index=1,
      number=2, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='packed_data', full_name='mediapipe.MatrixData.packed_data', index=2,
      number=3, type=2, cpp_type=6, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=b'\020\001', file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
    _descriptor.FieldDescriptor(
      name='layout', full_name='mediapipe.MatrixData.layout', index=3,
      number=4, type=14, cpp_type=8, label=1,
      has_default_value=True, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR,  create_key=_descriptor._internal_create_key),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
    _MATRIXDATA_LAYOUT,
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto2',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=61,
  serialized_end=229,
)

_MATRIXDATA.fields_by_name['layout'].enum_type = _MATRIXDATA_LAYOUT
_MATRIXDATA_LAYOUT.containing_type = _MATRIXDATA
DESCRIPTOR.message_types_by_name['MatrixData'] = _MATRIXDATA
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

MatrixData = _reflection.GeneratedProtocolMessageType('MatrixData', (_message.Message,), {
  'DESCRIPTOR' : _MATRIXDATA,
  '__module__' : 'mediapipe.framework.formats.matrix_data_pb2'
  # @@protoc_insertion_point(class_scope:mediapipe.MatrixData)
  })
_sym_db.RegisterMessage(MatrixData)


DESCRIPTOR._options = None
_MATRIXDATA.fields_by_name['packed_data']._options = None
# @@protoc_insertion_point(module_scope)
