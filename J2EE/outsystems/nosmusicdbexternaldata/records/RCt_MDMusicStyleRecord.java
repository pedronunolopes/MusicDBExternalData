package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MDMusicStyleRecord implements Serializable, Cloneable, ITypedRecord<RCt_MDMusicStyleRecord> {

	private static final GlobalObjectKey Idt_MDMusicStyle = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*HNhUh_cNO23UMNHG+giVQA");

	public static void ensureInitialized() {}
	public ENt_MDMusicStyleEntityRecord ssENt_MDMusicStyle;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MDMusicStyleEntityRecord toStructure() {
		return ssENt_MDMusicStyle;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MDMusicStyleRecord(ENt_MDMusicStyleEntityRecord r) throws Exception {
		ssENt_MDMusicStyle = (ENt_MDMusicStyleEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MDMusicStyle.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MDMusicStyle.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MDMusicStyleRecord() {
		OptimizedAttributes = null;
		ssENt_MDMusicStyle = new ENt_MDMusicStyleEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MDMusicStyle.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MDMusicStyle.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MDMusicStyle.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MDMusicStyle.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MDMusicStyleRecord r) throws Exception {
		this.ssENt_MDMusicStyle = (ENt_MDMusicStyleEntityRecord) r.ssENt_MDMusicStyle.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MDMusicStyleRecord)) {
			return false;
		}
		RCt_MDMusicStyleRecord b = (RCt_MDMusicStyleRecord) obj;
		if (!this.ssENt_MDMusicStyle.equals(b.ssENt_MDMusicStyle)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MDMusicStyle.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MDMusicStyle.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MDMusicStyle.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MDMusicStyleRecord duplicate() throws Exception {
		RCt_MDMusicStyleRecord t = new RCt_MDMusicStyleRecord();
		t.ssENt_MDMusicStyle = (ENt_MDMusicStyleEntityRecord) this.ssENt_MDMusicStyle.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MDMusicStyle.toXml(this, recordElem, "t_MDMusicStyle", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mdmusicstyle")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MDMusicStyle")) variable.setValue(ssENt_MDMusicStyle); else variable.setOptimized(true);
			variable.setFieldName("t_mdmusicstyle");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MDMusicStyleRecord t = (RCt_MDMusicStyleRecord) super.clone();
		t.ssENt_MDMusicStyle = (ENt_MDMusicStyleEntityRecord) this.ssENt_MDMusicStyle.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDMusicStyle.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDMusicStyle.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MDMusicStyle)) {
			return ssENt_MDMusicStyle;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MDMusicStyle.fillFromOther((IRecord) other.attributeGet(Idt_MDMusicStyle));
	}
}
